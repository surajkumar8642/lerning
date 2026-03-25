# EspoCRM Company Branding Change Guide

Last updated: March 22, 2026

Repo scanned: `C:\Work\lerarn\VideoCreate\espocrm`

## Goal

This file lists:

- what you can change from the `Admin UI`
- what you can change from the `Portal UI`
- what must be changed in `code`
- where `EspoCRM` still appears
- how to keep only a `small credit` in the About/footer area

## Important Legal Note

The repo is `AGPL-3.0` and the source headers explicitly say:

- modified interactive UIs must show `Appropriate Legal Notices`
- those notices must retain the word `EspoCRM`

So the practical safe rule is:

- you can replace most visible branding with your company name
- you should **not** remove all legal attribution
- you should keep a small `EspoCRM` credit in `About` and/or footer
- do not remove `LICENSE.txt`
- do not mass-delete header comments from source files

## Recommended Branding Strategy

Use this order:

1. Change everything possible from `Admin UI`
2. Change portal branding from `Portal` records
3. Change the remaining hardcoded branding in `code`
4. Keep a small legal credit mentioning `EspoCRM`

## 1. Change From Admin UI

These are the easiest and safest changes.

### Main app name

UI path:

- `Administration -> Settings -> User Interface`

Fields:

- `Application Name`
- `Company Logo`

Verified in code:

- `application/Espo/Resources/layouts/Settings/userInterface.json`
- `application/Espo/Resources/metadata/entityDefs/Settings.json`

Runtime usage:

- browser/page title
- navbar title behavior
- login/app branding text usage

Main code references:

- `application/Espo/Resources/defaults/config.php`
- `application/Espo/Core/Utils/ClientManager.php`
- `client/src/view.js`
- `client/src/controllers/base.js`

### Outbound email sender name

UI path:

- `Administration -> Settings -> Outbound Emails`

Field:

- `From Name`

This should be changed to your company name so emails do not say `EspoCRM`.

Verified in code:

- `application/Espo/Resources/layouts/Settings/outboundEmails.json`
- `application/Espo/Resources/metadata/entityDefs/Settings.json`
- `application/Espo/Resources/defaults/config.php`

## 2. Change From Portal UI

If you use customer portals, branding is separate.

UI path:

- `Administration -> Portal -> open a portal record`

Fields:

- `Application Name`
- `Company Logo`
- `Theme`

Verified in code:

- `application/Espo/Resources/layouts/Portal/detail.json`
- `application/Espo/Resources/metadata/entityDefs/Portal.json`

Runtime usage:

- portal navbar
- portal logo
- portal page title

## 3. Branding That Still Needs Code Changes

These parts are not fully covered by Admin UI and usually need file edits.

## A. About page

Main files:

- `application/Espo/Resources/texts/about.md`
- `application/Espo/Tools/App/Api/GetAbout.php`
- `client/src/views/about.js`
- `client/res/templates/about.tpl`

What to do:

- edit `application/Espo/Resources/texts/about.md`
- replace the long default product text with your company text
- keep a short legal credit mentioning `EspoCRM`

Recommended About content style:

- your company name and short CRM description
- version info stays as-is
- one short line such as:
  - `Powered by EspoCRM`
  - `Built on EspoCRM`

Do **not** fully remove the `EspoCRM` word from legal notice areas.

## B. Footer credit

Main file:

- `client/res/templates/site/footer.tpl`

Current behavior:

- footer shows `EspoCRM, Inc.` with a powered-by style link

What to do:

- reduce it to a smaller credit
- example:
  - `Powered by EspoCRM`
  - `Built on EspoCRM`

This is the best place to keep the required small credit.

## C. Installer branding

If you want installer screens to show your company instead of EspoCRM, check:

- `install/core/tpl/header.tpl`
- `install/core/tpl/footer.tpl`
- `install/core/tpl/finish.tpl`
- `install/core/tpl/main.tpl`
- `install/core/i18n/en_US/install.json`

Notes:

- installer translations in many languages also contain `EspoCRM`
- if you only care about English, change `install/core/i18n/en_US/install.json`
- if you support many languages, more files will need edits

Examples of installer text to change:

- `Welcome to EspoCRM`
- `Go to EspoCRM`
- installer footer credit

## D. Default fallback app name

If Admin UI is not yet configured, the default app name comes from:

- `application/Espo/Resources/defaults/config.php`

Important keys:

- `'applicationName' => 'EspoCRM'`
- `'outboundEmailFromName' => 'EspoCRM'`

What to do:

- change defaults if you want fresh installs to start with your company name
- still keep legal notice elsewhere

## E. Default logo fallback

If no company logo is uploaded, EspoCRM uses theme/default logo files.

Main files:

- `application/Espo/Core/Utils/ThemeManager.php`
- `application/Espo/Resources/metadata/themes/Light.json`
- `application/Espo/Resources/metadata/themes/Dark.json`
- `application/Espo/Resources/metadata/themes/Espo.json`
- `application/Espo/Resources/metadata/themes/EspoRtl.json`
- `application/Espo/Resources/metadata/themes/Glass.json`
- `application/Espo/Resources/metadata/themes/Hazyblue.json`
- `application/Espo/Resources/metadata/themes/Sakura.json`
- `application/Espo/Resources/metadata/themes/Violet.json`

Image files referenced there:

- `client/img/logo.svg`
- `client/img/logo-light.svg`

Runtime usage:

- `client/src/views/login.js`
- `client/src/views/site/navbar.js`
- `client/src/views/site-portal/navbar.js`
- `client/res/templates/login.tpl`
- `client/res/templates/site/navbar.tpl`

What to do:

- easiest: upload `Company Logo` from Admin UI
- stronger branding: replace fallback logo files too

## F. Login screen

Main files:

- `client/src/views/login.js`
- `client/res/templates/login.tpl`

What to know:

- login screen uses uploaded company logo if present
- otherwise it falls back to default logo/theme logo

So usually no direct code edit is needed if:

- `Company Logo` is set in Admin UI

## G. Navbar

Main files:

- `client/src/views/site/navbar.js`
- `client/src/views/site-portal/navbar.js`
- `client/res/templates/site/navbar.tpl`

What to know:

- navbar logo comes from `companyLogoId` first
- fallback is the theme logo

Usually:

- UI logo upload is enough
- code change only needed if you want deeper navbar redesign

## H. Source comments and legal headers

Many source files contain:

- `This file is part of EspoCRM`
- copyright notices
- AGPL notice
- `retain the display of the "EspoCRM" word`

Do **not** try to remove these everywhere.

That is not the right customization path.

## 4. Best Place To Keep Only a Small Credit

If you want your company branding everywhere and only one small EspoCRM credit:

Best places:

1. `application/Espo/Resources/texts/about.md`
2. `client/res/templates/site/footer.tpl`

Recommended result:

- app name = your company
- logo = your company
- portal name/logo = your company
- emails = your company
- About page = your company text + one small line `Built on EspoCRM`
- Footer = small `Powered by EspoCRM`

## 5. Where To Edit Safely

Prefer these methods in order:

### First choice: Admin UI

Use for:

- app name
- logos
- outbound email name
- portal branding

### Second choice: `custom/` overrides

EspoCRM supports custom resources under:

- `custom/Espo/Custom/Resources/...`

Verified by code:

- `application/Espo/Core/Utils/Metadata.php`
- `application/Espo/Core/Utils/Language.php`
- `application/Espo/Core/Utils/TemplateFileManager.php`
- `application/Espo/Core/Utils/Module/PathProvider.php`

Use `custom/` when possible for:

- metadata overrides
- i18n overrides
- templates
- layouts

Good custom paths:

- `custom/Espo/Custom/Resources/i18n/...`
- `custom/Espo/Custom/Resources/layouts/...`
- `custom/Espo/Custom/Resources/metadata/...`
- `custom/Espo/Custom/Resources/templates/...`

### Third choice: core file edits

Use core edits only when no UI/custom override is practical.

Core edit examples:

- `client/res/templates/site/footer.tpl`
- `application/Espo/Resources/texts/about.md`
- installer files under `install/`
- fallback logos under `client/img/`
- defaults in `application/Espo/Resources/defaults/config.php`

## 6. Minimum Change Checklist For Your Company

If you want a fast first pass, change these first:

1. Set `Application Name` in Admin UI
2. Upload `Company Logo` in Admin UI
3. Set `Outbound Email From Name`
4. Set portal `Application Name` and `Company Logo`
5. Edit `application/Espo/Resources/texts/about.md`
6. Edit `client/res/templates/site/footer.tpl`
7. Change fallback defaults in `application/Espo/Resources/defaults/config.php`
8. Replace `client/img/logo.svg` and `client/img/logo-light.svg`
9. Change installer text if you care about install screens

## 7. Fast Search Commands

Use these inside the repo to keep scanning:

```powershell
rg -n --hidden -S "EspoCRM|Espo CRM|espocrm" .
```

Only UI-facing likely files:

```powershell
rg -n --hidden -S "applicationName|companyLogo|outboundEmailFromName|logoSrc|About" application client install
```

## 8. My Recommendation

Do **not** try to remove every `EspoCRM` string from the repo.

Do this instead:

- replace product branding in UI with your company
- keep one small legal credit in footer and About
- keep license/header notices intact
- use `custom/` overrides where possible
- use core edits only for About/footer/installer/fallback assets

## 9. Files Most Important For Branding

- `application/Espo/Resources/defaults/config.php`
- `application/Espo/Resources/layouts/Settings/userInterface.json`
- `application/Espo/Resources/layouts/Settings/outboundEmails.json`
- `application/Espo/Resources/layouts/Portal/detail.json`
- `application/Espo/Resources/metadata/entityDefs/Settings.json`
- `application/Espo/Resources/metadata/entityDefs/Portal.json`
- `application/Espo/Resources/texts/about.md`
- `client/res/templates/about.tpl`
- `client/res/templates/site/footer.tpl`
- `client/res/templates/site/navbar.tpl`
- `client/res/templates/login.tpl`
- `client/src/views/login.js`
- `client/src/views/site/navbar.js`
- `client/src/views/site-portal/navbar.js`
- `application/Espo/Core/Utils/ThemeManager.php`
- `client/img/logo.svg`
- `client/img/logo-light.svg`
- `install/core/tpl/header.tpl`
- `install/core/tpl/footer.tpl`
- `install/core/tpl/finish.tpl`
- `install/core/i18n/en_US/install.json`

## 10. If You Want Next Step

I can do either of these next:

1. create a `company-branding patch` with the safe first-pass changes
2. create a `custom/ override structure` so updates are easier
3. edit `About` and `footer` now to keep only a small `EspoCRM` credit
