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

- Load tweets from the `tweet.js` file of a Twitter archive.
- Display tweets dispatched in three views : main, replies and retweets.
- Filter and search using a term and/or a user name.
- Open a tweet in browser.
- Delete i.e. destroy selected tweets.
- Display following and followers with changes tracking.
- Export tweets, following and followers to CSV.
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

[![Wireframe](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe-400x281.jpg)](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe.jpg)

## Frequently asked questions

#### How to install SQlite ODBC Driver?

The setup installs:

- [sqliteodbc.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc.exe) on Windows 32-bit.
- [sqliteodbc_w64.exe](http://www.ch-werner.de/sqliteodbc/sqliteodbc_w64.exe) on Windows 64-bit.

In the event that an error message indicates that a DLL file could not be copied, it is usually due to the fact that an application using this driver already installed is running and is blocking the file. You can ignore this error or close the application in question and restart the installation to obtain a driver update.

#### What to do in case of ODBC datasource connection error?

The software tries to register an ODBC DSN to the registry but in case of problem run:

&emsp;`C:\Program Files\Ordisoftware\Tweets Inspector\System\RegisterODBC.reg`

Or open the ODBC Datasource Manager (Admin tools in Windows' Control panel) and create a user datasource named:

&emsp;`Tweets-Inspector` for `SQLite 3 ODBC Driver`

With Database Name sets to:

&emsp;`%USERPROFILE%\AppData\Roaming\Ordisoftware\Tweets Inspector\Tweets-Inspector.sqlite`

Watch the [video](https://www.youtube.com/watch?v=WPVF8pj9I3E).

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

#### 2021.04.23 - Version 0.1

- Wireframe.
