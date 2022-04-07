# TestService
Windows Service Test

Installing the Windows Service
Go to "Start" >> "All Programs" >> "Microsoft Visual Studio [version]" >> "Visual Studio Tools" then click "Developer Command Prompt for [version]".

Type the following command:

cd <physical location of your TestWindowService.exe file>
  
Next type the following command:

InstallUtil.exe “TestWindowService.exe”

and press Enter.
  
  
How to start the Windows Service
Since we chose StartType = Manual, we must start the Windows Service manually by visiting the "Services and Applications" window in the computer.

Select the Test Windows Service and click "Start" to start the service. Go to the "TestWindowService.exe" location to see the logs.

Uninstall the TestWindowService.exe.

cd <physical location of your TestWindowService.exe file>
and press Enter.
InstallUtil.exe /u “TestWindowService.exe”
And press enter.
After executing the preceding commands, the TestWindowService will be uninstalled from your computer.
