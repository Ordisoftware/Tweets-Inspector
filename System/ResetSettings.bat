@echo off
taskkill /im Ordisoftware.TwitterManager.exe
ping localhost -n 3 >NUL
start "" ..\Bin\Ordisoftware.TwitterManager.exe --reset