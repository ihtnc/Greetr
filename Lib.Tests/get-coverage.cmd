@echo off
echo Determinining code coverage...
.\TestTools\reportgenerator.exe "-reports:TestResults\**\*.xml" "-targetdir:TestReports"