# Developer Setup on CoMotionH3

Note: These steps were jotted down after getting solution working and debugging on new laptop. Edit as necessary. 

1. If not already done, Install the latest version of Visual Studio (2019 at this time): https://visualstudio.microsoft.com/downloads/

    Note: Be sure to check and install the "Mobile development with .NET" Workload under "Desktop & Mobile" section in Visual Studio Installer.

2. Clone the source Repository: https://dev.azure.com/Scurlock/_git/CoMotionH3

3. Open the `CoMotionH3` solution. If necessary, may need to right-click the `CoMotionH3.Android` and `CoMotionH3.iOS` projects to Reload them after downloading "Mobile development with .NET" workload.

4. Install/Activate the Android SDK Manager by going to Tools --> Android --> Android SDK Manager. Accept any/all license agreements.

5. Feel free to Edit/Create as many Virtual Android Devices as desired for various debugging situations within Android Device Manager. At this time, have setup Pixel 2 running Android Pie 9.0 and API v28 appear to be the base default device for emulation.

6. Right-click `CoMotionH3.Android` project and set as the Default Project.

7. Visual Studio will prompt you when attempting debug, so go ahead and enable Hyper-v for emulator acceleration: https://docs.microsoft.com/en-us/xamarin/android/get-started/installation/android-emulator/hardware-acceleration?tabs=vswin&pivots=windows

    Note: This Hypber-V enabling will require a full system restart to enact the change.
8. ## TROUBLESHOOTING: 

    There were some issues encountered when setting up on a PSRS machine with having a Super User (Admin) and non-SU regular account. Noticed on the PSRS machine, after doing all the above steps which sometimes needed SU credentials, the only debug option I was being given in non-Admin Visual Studio was the "Android Emulator" in dropdown. By launching the solution with Visual Studio as Admin, all emulated Android Devices appeared for selection.

    After several attempts, noted that in setup the Visual Studio Installer (for the "Mobile development with .NET" workload), Android Device Manager, and Android SDK Manager all launched by default by requesting ADMIN credentials - and seemingly, install under the Super User file path directory. 

    I noticed that regardless of being in Admin or non-Admin Visual Studio instance, when launching Android Device Manager (Tools --> Android --> Android Device Manager --> Right-Click on Pixel 2 --> Reveal in Explorer), file explorer could never find the file being sought in the regular user (JScurlock) pathway. After getting the solution to successfully launch and debug through an ADMIN Visual Studio instance, I copied all files at `C:\Users\SUJScurlock\.android` to `C:\Users\JScurlock\.android\avd`. Now the solution debugs as expected in a non-Admin Visual Studio instance.

9. Re-launch a non-Admin Visual Studio instance for the solution and attempt to Debug using the emulated Pixel 2. It may take some time for first spin-up, but should Build and Deploy to the emulated device for Debugging.

Hello, CoMotionH3 Mobile App using Xamarin.Forms!

