# Windows PC as Router/Gateway Instead of Proxy

Last updated: March 22, 2026

## Goal

Use this Windows PC as a `gateway/router` so client devices send normal traffic through it, instead of configuring an explicit proxy on every device.

This helps modern chatbot apps and other software work more normally.

## What This Setup Can Do

- route internet traffic for client devices
- do `NAT`
- apply rules by:
  - client `IP`
  - destination `IP`
  - `port`
  - protocol `TCP/UDP`
- optionally use `DNS filtering` for domain blocking

## What This Setup Cannot Do Well

Without a proxy or SSL inspection, Windows router mode cannot reliably filter:

- full `HTTPS URL paths`
- encrypted app requests at path level
- app traffic that hides behind shared domains/CDNs

So on Windows, the realistic control model is:

- `gateway + firewall + DNS filtering`

not:

- exact `URL-path filtering` like Squid

## Recommended Windows Design

You need `2 network adapters`:

- `WAN NIC`: connected to your internet modem/upstream router
- `LAN NIC`: connected to your switch or directly to users

Network flow:

`Internet` -> `WAN NIC on this PC` -> `Windows NAT/router` -> `LAN NIC` -> `clients`

## Best Windows Choices

There are two main ways:

1. `ICS` (`Internet Connection Sharing`)
2. `RRAS` (`Routing and Remote Access Service`)

## Option 1: ICS

Use this if:

- your network is small
- you want quick setup
- you do not need advanced routing control

Pros:

- simple
- built into Windows
- fast to start

Cons:

- limited control
- not ideal for production
- awkward for custom addressing and advanced rules

## Option 2: RRAS

Use this if:

- you want a more proper Windows router
- you need better routing/NAT structure
- this machine will stay as the gateway long-term

Pros:

- better than ICS
- proper NAT/routing role
- more manageable for a stable setup

Cons:

- still not as good as OPNsense/pfSense/Linux
- more setup work

## My Recommendation on Windows

If this is just a test or small office, start with `ICS`.

If this is a permanent setup, use `RRAS`.

If this is business-critical, Windows is still not the best long-term firewall/router platform.

## Basic Network Plan

Example LAN:

- LAN subnet: `192.168.50.0/24`
- Windows LAN NIC IP: `192.168.50.1`
- client gateway: `192.168.50.1`
- DNS:
  - either this PC
  - or your DNS filtering server such as `AdGuard Home` or `Pi-hole`

## Setup Path A: ICS

## Step 1: Prepare Interfaces

1. Plug internet/upstream into `WAN NIC`.
2. Plug switch/client side into `LAN NIC`.
3. Rename adapters in Windows so they are clear:
   - `WAN`
   - `LAN`

You can do that in:

- `Control Panel` -> `Network and Sharing Center` -> `Change adapter settings`

## Step 2: Configure LAN NIC

Set a static address on the LAN adapter.

Example:

- IP: `192.168.50.1`
- Mask: `255.255.255.0`
- Gateway: leave blank
- DNS: local choice

## Step 3: Enable ICS

1. Open `Network Connections`.
2. Right-click the `WAN` adapter.
3. Open `Properties`.
4. Open the `Sharing` tab.
5. Enable:
   - `Allow other network users to connect through this computer's Internet connection`
6. Select the `LAN` adapter as the home networking connection.

Windows will enable shared internet access and basic NAT.

## Step 4: Point Clients to This PC

For each client:

- IP: from your DHCP or static
- Gateway: `192.168.50.1`
- DNS: your preferred DNS server

If you do not have DHCP on the LAN side, you will need static client settings or a separate DHCP service.

## Step 5: Add Firewall Rules

Use `Windows Defender Firewall with Advanced Security`.

Create rules for:

- block unwanted ports
- allow required ports
- restrict traffic by remote IP
- restrict traffic by local subnet if needed

Examples:

- block `UDP 443` to reduce `QUIC`
- allow `TCP 80`
- allow `TCP 443`
- block specific destination IP ranges if required

## Setup Path B: RRAS

Use this if you want a more structured router setup.

## Step 1: Install RRAS Role

On Windows Server:

- install the `Remote Access` role
- enable `Routing`

On Windows desktop editions, RRAS support is limited and not ideal. If you are on Windows 10/11 desktop, `ICS` is usually the realistic built-in choice.

## Step 2: Assign Interfaces

- `WAN NIC` connected upstream
- `LAN NIC` connected to internal network

Give the LAN NIC a static address, for example:

- `192.168.50.1/24`

## Step 3: Enable NAT

In RRAS:

- enable LAN routing
- enable NAT on the WAN-facing interface

## Step 4: DHCP and DNS

Choose one:

- let another device provide DHCP
- run DHCP on Windows Server

Clients should receive:

- IP in LAN subnet
- gateway = this PC
- DNS = your chosen DNS resolver/filter

## Step 5: Apply Firewall Policy

Use Windows Firewall to control:

- source subnet
- remote address
- protocol
- ports

This is where most of your `Squid-like` access restrictions become:

- `IP-based rules`
- `port-based rules`
- protocol restrictions

## Domain Blocking on Windows

If you want to block services like chatbots without using proxy mode, domain-level filtering is the practical method.

Options:

1. run `AdGuard Home` on this PC
2. run `Pi-hole` on another machine
3. use a filtering DNS provider

Then force clients to use that DNS.

Possible policy:

- block `chat.openai.com`
- block `claude.ai`
- block `gemini.google.com`
- block other AI service domains

Important:

- many services use multiple domains
- some apps fall back to direct IPs or related API domains
- DNS filtering is effective, but not perfect

## Important Rule: Block DNS Bypass

If clients can use any DNS server on the internet, they can bypass your domain rules.

So you should:

- allow DNS only to your approved resolver
- block outbound `TCP/UDP 53` from clients to other destinations
- consider `DoH` and `DoT` bypasses

## Important Rule: Block QUIC

Many modern apps and browsers use `HTTP/3` over `UDP 443`.

That can reduce visibility and affect control.

A common rule is:

- block outbound `UDP 443`

This forces many apps and browsers back to `TCP 443`.

## Bandwidth and Device Control

Windows is weak at advanced bandwidth shaping compared with real firewall systems.

You can still do:

- per-device allow/block
- per-port allow/block
- destination IP restrictions

If you need true traffic shaping, quotas, or clean reporting, Windows is not ideal.

## Mapping Your Old Squid Rules to Windows Router Rules

What maps well:

- source client `IP`
- allowed/blocked `ports`
- destination `IP` networks
- schedule-based firewall rules
- DNS/domain blocks

What does not map well:

- full `URL` path filtering
- browser-specific web policy at HTTPS path level
- detailed per-request logging like a proxy

## Practical Example Policy

For users on `192.168.50.0/24`:

- allow `TCP 80`
- allow `TCP 443`
- block `UDP 443`
- block `TCP/UDP 53` to all destinations except your DNS server
- block selected chatbot domains at DNS layer
- block unwanted remote IPs at firewall layer

## Why Chatbots Will Work Better

In this model:

- clients are not forced to speak proxy
- apps use standard networking
- TLS sessions stay end-to-end
- browser and desktop app behavior is more normal

That usually fixes many proxy-related breakages.

## Limits You Should Accept

If you want all modern apps to work and still want central filtering, the realistic compromise is:

- control by `IP`, `port`, `protocol`, `DNS/domain`

not:

- exact encrypted `URL` filtering

If exact URL filtering is mandatory, you will need:

- proxy
- SSL inspection
- or endpoint management on every client

## Better Long-Term Alternative

If this Windows router works only as a temporary migration, that is reasonable.

For a cleaner permanent setup, move to:

1. `OPNsense`
2. `pfSense`
3. `Linux router + AdGuard Home`

## Suggested Next Work

If you want, I can create one more file with either:

1. `Windows ICS step-by-step commands and screenshots checklist`
2. `Windows firewall rule plan for blocking chatbot sites`
3. `migration checklist from Squid proxy to Windows gateway`
