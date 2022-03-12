#define MyAppVersion "0.3"
#define MyAppName "Tweets Inspector"
#define MyAppNameNoSpace "TweetsInspector"
#define MyAppExeName "Ordisoftware.Tweets.Inspector.exe"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "https://www.ordisoftware.com/projects/tweets-inspector"

[Setup]
MinVersion=0,10.0
LicenseFile=..\Project\Licenses\MPL 2.0.rtf
AppCopyright=Copyright 2022 Olivier Rogier
AppId={{482BB78E-469E-4FE1-935A-D6B8E8D5017C}
;AppMutex=1ed45f34-0cd1-42b3-a65b-28b15693ab27
#include "Scripts\Setup.iss"

[Languages]
#include "Scripts\Languages.iss"

[Dirs]

[InstallDelete]
#include "Scripts\InstallDelete.iss"

[Files]
#include "Scripts\Files.iss"

[Run]
#include "Scripts\Run.iss"

[Registry]

[Tasks]
#include "Scripts\Tasks.iss"

[Icons]
#include "Scripts\Icons.iss"

[CustomMessages]
#include "Scripts\Messages.iss"

[Code]
#include "Scripts\CheckDotNetFramework.iss"
