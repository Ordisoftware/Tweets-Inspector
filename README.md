[![License: MPL 2.0](https://img.shields.io/github/license/ordisoftware/tweets-inspector)](LICENSE)&nbsp;
[![GitHub all releases downloads](https://img.shields.io/github/downloads/ordisoftware/tweets-inspector/total)](https://github.com/Ordisoftware/Tweets-Inspector/releases)&nbsp;
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/ordisoftware/tweets-inspector)](https://github.com/Ordisoftware/Tweets-Inspector/releases/latest)&nbsp;
[![GitHub repo size](https://img.shields.io/github/repo-size/ordisoftware/tweets-inspector)](#)&nbsp;
[![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/ordisoftware/tweets-inspector)](https://github.com/Ordisoftware/Tweets-Inspector/tree/master/Project)&nbsp;
[![Lines of code](https://img.shields.io/tokei/lines/github/ordisoftware/tweets-inspector)](https://github.com/Ordisoftware/Tweets-Inspector/tree/master/Project)&nbsp;<br/>
[![OS: Windows](https://img.shields.io/badge/Windows%2010-279CE8?label=os)](https://www.microsoft.com/windows/)&nbsp;
[![UI: WinForms](https://img.shields.io/badge/WinForms-279CE8?label=ui)](https://github.com/dotnet/winforms)&nbsp;
[![Framework: .Net](https://img.shields.io/badge/.NET%204.8-6E5FA6?label=framework)](https://dotnet.microsoft.com)&nbsp;
[![IDE: Visual Studio](https://img.shields.io/badge/Visual%20Studio%202022-6E5FA6.svg?label=ide)](https://visualstudio.microsoft.com)&nbsp;
[![Lang: C#](https://img.shields.io/badge/C%23%2011-%23239120.svg?label=lang)](https://docs.microsoft.com/dotnet/csharp/)&nbsp;
[![DB: SQLite](https://img.shields.io/badge/SQLite%203.35-darkgoldenrod.svg?label=db)](https://www.sqlite.org)&nbsp;<br/>
[![Ordisoftware.com Project](https://img.shields.io/badge/-Ordisoftware.com%20Project-355F90?logo=WordPress&logoColor=white)](https://www.ordisoftware.com/tweets-inspector)&nbsp;
[![Manufacturing Software Guidelines](https://img.shields.io/badge/-Manufacturing%20Software%20Guidelines-355F90?logo=MicrosoftWord&logoColor=white)](https://github.com/Ordisoftware/Guidelines)&nbsp;

# Tweets Inspector

A libre and open-source software written in C# that allows to list, filter and delete tweets from a Twitter account, as well as to get following and followers list.

The author is not responsible for tweets destroyed if you click on "Delete".

___NOTE 2022.05___:<br>
In case of error 404 or 403 while connecting to Twitter, the problem which is the timeout of the Twitter logged session in CefSharp not currently managed by the software - a trick for now is to erase this folder:<br>
`c:\Users\[name]\AppData\Roaming\Ordisoftware\Tweets Inspector\ChromiumCache\`

## Table of content

1. [Functionalities](#functionalities)
2. [Requirements](#requirements)
3. [Download](#download)
4. [Screenshots](#screenshots)
5. [Frequently asked questions](#frequently-asked-questions)
6. [Keyboard shortcuts](#keyboard-shortcuts)
7. [Future improvements](#future-improvements)
8. [Changelog](#changelog)

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
- Windows 10 x32/x64 or higher
- Framework .NET 4.8
- SQLite 3.38.3
- CefSharp for automatic authentication

## Download

**What's new in the latest version**

- Prototype #1.

[Last release](https://github.com/Ordisoftware/Tweets-Inspector/releases/latest)

## Screenshots

[![Wireframe](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe2-400x267.png)](https://www.ordisoftware.com/uploads/2021/04/tweets-inspector-wireframe2.png)

## Frequently asked questions

#### What code analyzers are used in addition to Visual Studio?

|IDE Extension|Project NuGet| 
|-|-|
|[SonarLint](https://marketplace.visualstudio.com/items?itemName=SonarSource.SonarLintforVisualStudio2022)<br>[Roslynator](https://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2022)<br>[F0.Analyzers](https://marketplace.visualstudio.com/items?itemName=Flash0Ware.F0-Analyzers-VS)<br>[Parallel Helper](https://marketplace.visualstudio.com/items?itemName=camrein.ParallelHelper)<br>[Parallel Checker](https://marketplace.visualstudio.com/items?itemName=LBHSR.ParallelChecker)<br>[AsyncFixer](https://marketplace.visualstudio.com/items?itemName=SemihOkur.AsyncFixer2022)<br>[Async Method Name Fixer](https://marketplace.visualstudio.com/items?itemName=PRIYANSHUAGRAWAL92.AsyncMethodNameFixer)<br>[U2U Consult Performance Analyzers](https://marketplace.visualstudio.com/items?itemName=vs-publisher-363830.U2UConsultPerformanceCodeAnalyzersforC7)<br>[Security Code Scan](https://marketplace.visualstudio.com/items?itemName=JaroslavLobacevski.SecurityCodeScanVS2019)<br>[Puma Scan](https://marketplace.visualstudio.com/items?itemName=PumaSecurity.PumaScan)|[Microsoft.CodeAnalysis.NetAnalyzers](https://github.com/dotnet/roslyn-analyzers)<br>[Microsoft.VisualStudio.Threading.Analyzers](https://github.com/microsoft/vs-threading)<br>[MultithreadingAnalyzer](https://github.com/cezarypiatek/MultithreadingAnalyzer)<br>[Meziantou.Analyzer](https://github.com/meziantou/Meziantou.Analyzer)<br>[GCop.All.Common](https://github.com/Geeksltd/GCop)<br>[ReflectionAnalyzers](https://github.com/DotNetAnalyzers/ReflectionAnalyzers)<br>[IDisposableAnalyzers](https://github.com/DotNetAnalyzers/IDisposableAnalyzers)<br>[ErrorProne.NET.CoreAnalyzers](https://github.com/SergeyTeplyakov/ErrorProne.NET)<br>[ErrorProne.NET.Structs](https://github.com/SergeyTeplyakov/ErrorProne.NET)<br><br>|

#### What to do if the check update tells that the SSL certificate is wrong or expired?

The software verifies the validity of the certificate of the update server in addition to the SHA-512 checksum of the installation file before downloading and running it.

You can manually check the latest version available online in case of problem.

#### What to do if the application does not work normally despite restoring settings?

Use the Start Menu link:

&emsp;`Ordisoftware\Tweets Inspector\Reset Tweets Inspector settings`

This will erase all settings as well as those of old versions, which should resolve issues if there is a conflict, otherwise please contact support.

#### What is the Windows double-buffering?

When enabled, this will speed up rendering of the main form when it is displayed, but it may cause a slight black flicker.

When disabled, top menu and some controls painting may cause latency, and dynamic items can be generated slowly the larger the number.

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
| Alt + F4 | Exit application |

## Future improvements

## Changelog

#### In progress - Version 0.3

- Prototype #1.
- Switch from SQLite ODBC Driver to SQLite-Net with SQLitePCLraw nugets.

#### 2021.08.29 - Version 0.2

- Mockup.

#### 2021.04.23 - Version 0.1

- Wireframe.