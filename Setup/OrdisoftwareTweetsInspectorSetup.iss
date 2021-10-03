#define MyAppVersion "0.2"
#define MyAppName "Tweets Inspector"
#define MyAppNameNoSpace "TweetsInspector"
#define MyAppExeName "Ordisoftware.TweetsInspector.exe"
#define MyAppPublisher "Ordisoftware"
#define MyAppURL "https://www.ordisoftware.com/projects/tweets-inspector"

[Setup]
AppCopyright=Copyright 2021 Olivier Rogier
AppId={{482BB78E-469E-4FE1-935A-D6B8E8D5017C}
;AppMutex=1ed45f34-0cd1-42b3-a65b-28b15693ab27
#include "Scripts\Setup.iss"

[Languages]
#include "Scripts\Languages.iss"

[CustomMessages]
#include "Scripts\Messages.iss"

[Tasks]
#include "Scripts\Tasks.iss"


[Dirs]

[InstallDelete]
#include "Scripts\InstallDelete.iss"

[Files]
#include "Scripts\Files.iss"

[Icons]
#include "Scripts\Icons.iss"


[Registry]


[Run]
#include "Scripts\Run.iss"

[Code]
#include "Scripts\CheckDotNetFramework.iss"
