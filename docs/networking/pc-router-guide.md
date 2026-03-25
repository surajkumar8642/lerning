# Using This PC as a Router Instead of a Proxy

Last updated: March 22, 2026

## Your Current Situation

Right now this PC is working like a `Squid proxy`.

That means:

- clients must send traffic to the proxy
- you can limit by `IP`, `port`, and sometimes `URL`
- some modern apps and chatbots do not work well because they do not fully support explicit proxy mode
- many services use `HTTPS`, `HTTP/2`, `HTTP/3`, `QUIC`, certificate pinning, and non-browser traffic, which makes proxy-based filtering incomplete or fragile

## What You Want

You want this PC to behave like an `internet gateway/router`, not just a proxy:

- client devices use this PC as their `default gateway`
- traffic passes through this PC automatically
- apps work more normally because they are not forced to use an explicit proxy
- you still want controls like:
  - block/allow by `IP`
  - block/allow by `port`
  - block/allow by `domain` or `URL`
  - per-device rules
  - bandwidth or time limits

## Important Reality

`IP` and `port` filtering work well on a router.

`Full URL` filtering does **not** work reliably on a normal router unless you do one of these:

- use an explicit proxy
- do `HTTPS inspection / SSL interception`
- block by `domain name` instead of full URL path

Reason:

- modern websites mostly use `HTTPS`
- the router can usually see the destination IP, port, DNS queries, and sometimes the TLS hostname
- the router usually **cannot** see the full encrypted URL path like `/chat/new` without breaking and inspecting TLS

So the correct goal is usually:

- use the PC as a `router/firewall`
- filter by `IP`, `port`, `DNS/domain`, and `TLS hostname`
- avoid full URL filtering unless you accept SSL interception

## Best Practical Options

## Option 1: Use This PC as a Real Router/Firewall

Best for stability.

Recommended stack:

- `2 network adapters`
  - one `WAN` adapter connected to internet/upstream
  - one `LAN` adapter connected to your switch or local users
- enable `NAT`
- run `DHCP` for clients or keep your existing DHCP server
- apply firewall rules on the gateway
- use `DNS filtering` for domain blocking

Good software choices:

- `pfSense` or `OPNsense` on dedicated hardware or this PC
- `OpenWrt` if hardware supports it
- `Linux router` using `nftables`/`iptables` + `dnsmasq` or `unbound`
- `Windows RRAS` if you must stay on Windows, but it is less ideal for advanced filtering

If you want the cleanest result, `OPNsense` or `pfSense` is the strongest path.

## Option 2: Keep Squid Only for Selected Traffic

Best when you still need detailed web filtering for browsers.

Design:

- PC acts as the router for all devices
- most traffic is routed normally
- browser traffic can still go through proxy rules if needed
- non-browser apps and chat apps bypass explicit proxy

This is often better than forcing every application through Squid.

## Option 3: Router + DNS Filtering

Best balance between control and compatibility.

Use:

- router/firewall for `IP` and `port`
- `Pi-hole`, `AdGuard Home`, `Technitium DNS`, or firewall DNS rules for domain filtering

This works well for:

- blocking AI/chat domains
- blocking categories
- limiting access per device
- avoiding proxy problems

This does **not** give exact path-based URL filtering.

## Recommended Design

For your case, I recommend:

1. Make this PC the `default gateway/router`.
2. Stop forcing clients to use explicit Squid proxy for all traffic.
3. Apply rules at the gateway:
   - `IP`
   - `port`
   - `device/IP-based policies`
4. Add `DNS/domain filtering`.
5. Block `QUIC/UDP 443` so browsers fall back to normal `HTTPS/TCP 443` when needed.
6. Only use proxy or SSL inspection if you truly need exact URL-path filtering.

This gives the best compatibility for modern chatbot apps.

## How To Build It

## If You Stay on Windows

You need:

- two NICs:
  - `Internet NIC`
  - `LAN NIC`

Basic flow:

1. Connect upstream internet to `NIC 1`.
2. Connect your LAN/switch to `NIC 2`.
3. Give `NIC 2` a static LAN IP, for example `192.168.50.1/24`.
4. Enable routing/NAT:
   - small setup: `Internet Connection Sharing (ICS)`
   - better setup: `RRAS`
5. Set client devices:
   - gateway = this PC LAN IP
   - DNS = your chosen DNS filter or this PC
6. Add Windows Firewall rules for:
   - allowed ports
   - blocked ports
   - per-network restrictions

Windows limits:

- not ideal for advanced domain/TLS filtering
- not ideal for high-performance routing
- harder to manage than a firewall OS

## If You Use Linux

This is a better DIY router platform.

You need:

- IP forwarding
- NAT/masquerade
- DHCP server or existing DHCP server
- firewall rules
- DNS filter

Typical components:

- `nftables` for firewall/NAT
- `dnsmasq` or `isc-dhcp-server` for DHCP
- `AdGuard Home` or `Pi-hole` for domain filtering

Linux is much better than Windows if you want this PC to stay a permanent router.

## If You Use OPNsense/pfSense

This is the best path for long-term use.

Why:

- built for router/firewall use
- clean web UI
- NAT, DHCP, VLAN, firewall, traffic shaping
- DNS/domain controls
- logging per client
- easier to maintain than a custom Windows setup

Typical setup:

1. Install `OPNsense` or `pfSense` on this PC.
2. Assign one interface as `WAN`.
3. Assign one interface as `LAN`.
4. Enable DHCP on LAN.
5. Set client machines to use the LAN side.
6. Add firewall rules by source IP/device.
7. Add DNS/domain blocking.
8. Optionally block `UDP/443` to reduce QUIC bypass.

## About URL Filtering

You mentioned limiting by `URL` like Squid.

Here is the rule:

- `Domain filtering` is realistic on a router.
- `Full URL path filtering` is usually not realistic without SSL interception.

Examples:

- You can block `chat.openai.com` or `claude.ai` by domain.
- You usually cannot reliably block only `https://example.com/some/path` on a normal router.

If you require exact URL filtering, you have to use:

- explicit proxy, or
- transparent proxy with SSL interception, or
- endpoint/device management software

That adds complexity and can break apps.

## Why Modern Chat Apps Break with Proxy

Common reasons:

- they do not support manual proxy config well
- they use certificate pinning
- they use WebSocket, HTTP/2, or HTTP/3/QUIC
- they open direct TLS connections outside normal browser proxy behavior
- they expect system networking, not browser-style proxy networking

That is why gateway routing is usually better than explicit proxying.

## Best Answer for Your Goal

If your goal is:

- apps should work normally
- control should stay central
- rules should apply per user/device/IP

Then do this:

- convert this machine into a `router/firewall`
- use `NAT + firewall + DNS filtering`
- use `domain blocking`, not full HTTPS path filtering
- optionally block `UDP 443`
- only keep Squid for special browser use cases

## Suggested Final Architecture

- `ISP modem/router` -> `This PC (router/firewall)` -> `Switch/Wi-Fi AP` -> `Client devices`

Rules on this PC:

- firewall rules by `source IP`
- allowed/blocked `ports`
- DNS policy by `device`
- domain blocklists
- optional bandwidth shaping

## My Recommendation

If this is for real production use, do not keep Windows + Squid as the main control point.

Use one of these:

1. `OPNsense` on this PC
2. `pfSense` on this PC
3. `Linux router` with `nftables` + `AdGuard Home`

If you want the easiest admin experience, choose `OPNsense`.

## Next Step

If you want, the next file I can create is one of these:

- a `Windows router setup guide`
- a `Linux router setup guide`
- an `OPNsense step-by-step migration plan from Squid`
- a `sample rule design` for blocking chatbots by domain, IP, port, and device
