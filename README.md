# YouAreAnIdiot-UnFlash
This is a near 1:1 remake of YouAreAnIdiot.exe (originally made by KenYue) without its dependency on Flash Player!
![image](https://github.com/user-attachments/assets/a0c37865-7fcc-4ece-9ce3-fb5a66ec25cf)
![image](https://github.com/user-attachments/assets/347be110-8d6b-480c-932a-e8a559c201ba)

## Introduction
On 17 October 2010, a video featuring the original version of YouAreAnIdiot.exe was published on YouTube by KenYue, evidently inspired by Trojan.JS.YouAreAnIdiot - a basic app made on C# Windows Forms which allowed it to run natively on Windows. Just like Trojan.JS.YouAreAnIdiot, it quickly gained traction on the Internet and various videos surfaced of people trying this sample out.

**However, the original version of YouAreAnIdiot.exe had a fatal flaw. Two, actually.**

- Firstly, as seen through external references via the DLL files it came with (AxInterop.ShockwaveFlashObjects.dll and Interop.ShockwaveFlashObjects.dll), it fundamentally relied on Adobe Shockwave/Flash Player to work. Back in 2010, yeah well, it wasn't very much of a problem, since pretty much every computer had some version of Adobe Flash Player installed (why wouldn't you?) but as some of you might know, Flash Player was killed in 2021 and a time bomb was added to later versions of Flash Player by Adobe to prevent its use in light of the major security risks it posed to computers that had it installed. Therefore, when you tried to launch it on a modern system, the app would pretty much just crash and refuse to launch.

- Secondly, it had a hardcoded reference to download the youare.swf file (which provides the animation and the music) straight from the youareanidiot[.]org website. As you might know, that has been taken down for almost 10 years now and even if you fixed the Flash Player issue, the app would launch with the main You Are An Idiot animation and music missing.

There are, of course, workarounds to these, which included installing an older version of Flash Player beforehand, as well as setting up with a Python HTTP server and setting requests to youareanidiot[.]org to point to localhost instead, but that's troublesome.

Therefore, I created YouAreAnIdiot-UnFlash to avoid having to do that, which I rebuilt totally from the ground up. No source code was provided by KenYue, which meant that I had to rely on C# .NET decompilation tools to get back some parts of the source code, some of which I borrowed in the making of this project. The decompiled result was also a mess and required too many fixes to work, making rebuilding from the ground up way easier.

> [!NOTE]
> This project was initially made for my friends over at NullSec SIG - Ngee Ann Polytechnic's cybersecurity-focused SIG, as part of a demonstration of what a BadUSB can do.
>
> If you'd like to check out their project, including how they integrated a gamified version of my project into a BadUSB, check out their repo here! https://github.com/NullSec-SIG/YouAreAnIdiot-BadUSB-Demo
> ![DSC05769](https://github.com/user-attachments/assets/26e271ce-159c-40ff-8ea0-52ea9be9f06a)

## Installation
No installation is required as this is a portable executable, and I have used a packer to pack all the DLLs it depends on inside for your convenience. All you have to do is run the singular exe file.

You can find compiled exes in the [Releases](https://github.com/orangegrouptech/YouAreAnIdiot-UnFlash/releases) tab.

## Requirements
- .NET Framework 4.7.2 or later
- Windows 7 or later (unless you can get 4.7.2 to work on Vista)
- 32-bit or 64-bit or ARM64 supported
