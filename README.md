# Tweets Inspector

> Licensed under the terms of the [Mozilla Public License 2.0](LICENSE)<br/>
> This project follows the [Manufacturing Software Guidelines](https://github.com/Ordisoftware/Guidelines).<br/>
> [Website](https://www.ordisoftware.com/projects/tweets-inspector)<br/>
> [Twitter](https://twitter.com/ordisoftware)<br/>

A libre and open-source software written in C# that allows to list, filter and delete tweets from a Twitter account.

The author is not responsible for tweets destroyed if you click on "Delete".

## Table of content

1. [Functionalities](#Functionalities)
2. [Requirements](#Requirements)
3. [Download](#Download)
4. [Screenshots](#Screenshots)
5. [Frequently asked questions](#Frequently-asked-questions)
6. [Keyboard shortcuts](#Keyboard-shortcuts)
7. [Future improvements](#Future-improvements)
8. [Changelog](#Changelog)

## Functionalities

- Auto-connect to Twitter account.
- Load tweets from the `tweet.js` file of a Twitter archive.
- Display tweets dispatched in three views : main, replies and retweets.
- Display following and followers with changes tracking.
- Filter and search using terms and/or user names to include or exclude.
- Open selected tweets in browser.
- Delete i.e. destroy selected tweets.
- Automatic tweet deletion scheduler.
- Checker for online destroyed tweets.
- Bin of deleted tweets.
- Export tweets, following and followers to CSV/JSON.
- English, French.

## Requirements

- Windows 10 x32/x64 or higher
- Screen 1024x768 or higher
- Framework .NET 4.7.2
- SQLite ODBC Driver
- CefSharp is included for an automatic authentication

## Download

**What's new in the latest version**

- Wireframe.

[Last release](https://github.com/Ordisoftware/Tweets-Inspector/releases/latest)

## Screenshots

[![Wireframe](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe2-400x267.png)](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe2.png)

## Frequently asked questions

#### What to do if the check update tells that the SSL certificate is wrong or expired?

The software verifies the validity of the certificate of the update server in addition to the SHA-512 checksum of the installation file before downloading and running it. This certificate is normally updated within the two months of its annual expiration and a new version is released. You can manually check the latest version available online in case of problem.

#### Are personal data collected?

This software doesn't collect any personal information about you, your computer and your network, unless it is specified by its features.

However, it can collect for debugging purposes the type of processor and operating system as well as errors caused by the code, but these information are only stored locally and only transmitted upon conscious validations by the user.

#### What about possible virus issues?

Alerts since spring 2021 regarding a *Trojan.Malware.300983.susgen* from a little known vendor, and a *Nibiru detection* from a Crowdsourced Sigma rule, appear to be false positives.

Kaspersky, F-Secure, Trend Micro, McAfee, CrowdStrike Falcon, MetaDefender and Malwarebytes could not find anything on the solo-computer that is behind software and hardware firewalls, and which is used to create the binaries. Additionally, inspection of the Windows registry and file system did not reveal anything conclusive about a potential infection. A cursory review of the source code, just like using an old workstation backup, could not identify the cause of these flags.

All Hebrew software use certain functions of the Windows system like for error tracing and global keyboard shortcuts management, as well as multiple timers, and some command line options to control each other via IPC. The author also uses advanced coding techniques such as generics and factorizations, and the database access layer has been completely rewritten for Calendar 8, Letters 6 and Words 3.

If in doubt, the source code can be build using Visual Studio 2017 or later. Please do not hesitate to contact the author or create a GitHub Issue if you have any information on this, and if there is a real problem with the binaries or the source code.

#### What are command-line options?

- Change interface language:

  `Ordisoftware.TweetsInspector.exe --lang [en|fr]`

## Keyboard shortcuts

| Keys | Actions |
|-|-|
| Alt + T | Tools menu |
| Alt + S | Settings menu |
| Alt + I | Information menu |
| F9 | Preferences |
| F10 | Log file window |
| F11 | Usage statistics window |
| F12 | About |
| Alt + F4 (or Escape) | Exit application |

## Future improvements

## Changelog

#### In progress - Version 1.0

- Initial release.

#### 2021.04.23 - Version 0.1

- Wireframe.