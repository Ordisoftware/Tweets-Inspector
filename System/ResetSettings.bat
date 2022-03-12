@echo off
taskkill /im Ordisoftware.Tweets.Inspector.exe
ping localhost -n 3 >NUL
start "" ..\Bin\Ordisoftware.Tweets.Inspector.exe --reset