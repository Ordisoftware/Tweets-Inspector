[![GitHub](https://img.shields.io/github/license/ordisoftware/tweets-inspector)](#)&nbsp;
[![GitHub all releases](https://img.shields.io/github/downloads/ordisoftware/tweets-inspector/total)](#)&nbsp;
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/ordisoftware/tweets-inspector)](#)&nbsp;
[![GitHub repo size](https://img.shields.io/github/repo-size/ordisoftware/tweets-inspector)](#)&nbsp;
[![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/ordisoftware/tweets-inspector)](#)&nbsp;
[![Lines of code](https://img.shields.io/tokei/lines/github/ordisoftware/tweets-inspector)](#)&nbsp;<br/>
[![Windows](https://img.shields.io/badge/Windows%207+-0078D6)](#)&nbsp;
[![.Net](https://img.shields.io/badge/.NET%204.8-5C2D91)](#)&nbsp;
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio%202022-5C2D91.svg)](#)&nbsp;
[![C#](https://img.shields.io/badge/C%23%2010-%23239120.svg)](#)&nbsp;
[![SQLite](https://img.shields.io/badge/SQlite%203.35-%2307405e.svg)](#)&nbsp;<br/>
[![Ordisoftware.com](https://img.shields.io/badge/-Ordisoftware.com-355F90?logo=WordPress&logoColor=white)](https://www.ordisoftware.com/tweets-inspector)&nbsp;
[![Guidelines](https://img.shields.io/badge/-Guidelines-355F90?logo=MicrosoftWord&logoColor=white)](https://github.com/Ordisoftware/Guidelines)&nbsp;

# Tweets Inspector

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

- Screen 1024x768 or higher
- Windows 7 SP1 x32/x64 or higher
- Framework .NET 4.8
- SQLite 3.35.5
- CefSharp for automatic authentication

## Download

**What's new in the latest version**

- Wireframe.

[Last release](https://github.com/Ordisoftware/Tweets-Inspector/releases/latest)

## Screenshots

[![Wireframe](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe2-400x267.png)](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe2.png)

## Frequently asked questions

#### What to do if the check update tells that the SSL certificate is wrong or expired?

The software verifies the validity of the certificate of the update server in addition to the SHA-512 checksum of the installation file before downloading and running it. This certificate is normally updated within the two months of its annual expiration and a new version is released. You can manually check the latest version available online in case of problem.

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
- Nuget SQLitePCLRaw.bundle_green must remain `v2.0.4`.

#### 2021.08.29 - Version 0.2

- Mockup.

#### 2021.04.23 - Version 0.1

- Wireframe.
