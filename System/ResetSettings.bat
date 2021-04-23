@echo off
taskkill /im Ordisoftware.TweetsInspector.exe
ping localhost -n 3 >NUL
start "" ..\Bin\Ordisoftware.TweetsInspector.exe --reset
