# monogame-vscode-boilerplate
A Monogame C# configuration for Visual Studio Code (on Windows)

## Prerequisites

* [MonoGame (for Visual Studio)](http://www.monogame.net/downloads/)
* [.NET Core SDK (2.x)](https://www.microsoft.com/net/learn/get-started/windows)
* [Visual Studio Code (Windows version)](https://code.visualstudio.com/download)
  * [Official C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
* [Git Bash (for Windows) ](https://git-scm.com/downloads)

## Installation

1. Download & Install MonoGame. Get the "for Visual Studio" version although VS is not actually needed. Install with the default options checked off
2. Download & Install .NET Core SDK
3. Download & Install Visual Studio Code if you don't already have it
4. Install the official **C#** Extension, reload the window & wait for the dependencies to install
5. If on Windows, install **Git Bash**, and ensure the **"terminal.integrated.shell.windows"** property in the project's **settings.json** is set to **bash.exe**'s correct location. We'll be using this for the terminal in our workspace so that the Makefile can run in both Windows, Mac & Linux (although Mac configuration is untested thus far)

## Configuration

At this point, everything you need is installed

1. Open the **monogame-vscode-boilerplate** folder in VS Code. You should see an orange/red status bar at the bottom (color-picked from the MonoGame logo).
2. You should be able to run a build task (**Ctrl+Shift+B** > **Build & Run**), but it'll be nicer to add keybindings for these tasks so you can build with 1 keypress.
3. Open the .vscode folder and click on the **\_keybindings.json** file. This is not an officially recognized file, but just contains the keybindings you can copy into the actual keybindings.json file.
4. Go into **File** > **Preferences** > **Keyboard Shortcuts** & click on the keybindings.json link at the top.
5. Copy the keybindings into this file. Feel free to change them if you don't like them later.
6. Hit the **F9** key to run the **Build & Run: Release** task. It should run the Makefile, find the compiler, build the Main.cpp into Main.o, and launch the blue screen that you may recognize from MonoGame tutorials. **Shift+F9** will launch the last built Release, whereas **F10** & **Shift+F10** do the same for the Debug build.

The only difference in the Debug build is simple use of the console via a custom "Log" class - Log.Print(String). Feel free to take this out if you just want to use the normal debugger via **F8**.

## .vscode folder

* **.vscode\\settings.json** - Contain all of your workspace settings & overrides VS Code's main settings.json. Here are some settings of interest:

  * **_"files.exclude"_** - Add any filetypes you want to exclude from the folder panel.
  * **_"files.encoding"_** - This is set to  **windows1252**, but feel free to change it to suit your needs.
  * **_"editor.fontFamily"_** - I set this to Courier by default. Change/remove this line if you want to stick to VS Code's default (Consolas), or your own preference. Same with **"editor.fontSize"** & **"editor.lineHeight"**.

* **.vscode\\launch.json** - Used to store the configuration to launch the debugger.
* **.vscode\\tasks.json** - Used to store the task definitions (Build & Run commands, etc.).
* **.vscode\\_keybindings.json** - As mentioned before, this is used purely to store handy keybindings that one can add themselves, and not recognized by VS Code.

## Notes

* This is based on the **MonoGame.Framework.DesktopGL.Core** template, but can be adapted easily to the others
* This configuration assumes all source files are contained within the **src** folder, but uses the **root** as the working directory for assets & things referenced in your project.
* Feel free to offer suggestions/report issues if there's anything I missed, or could do better.
* This will be an ongoing project as I learn more about C# and MonoGame.
* Upon the initial load in VS Code, you'll see numerous "problems" trigger. Simply build the game once and these should go away.
* This config is based on https://github.com/dotnet/corert/tree/master/samples/MonoGame

## Publishing

VS Code & .Net Core are pefect for development since they are both nice and fast, however, creating the final exe & publishing via .NET Core isn't recommended for now since it's kind of limited. You'll want to have a full Visual Studio 2017 install configured (See: https://www.codeproject.com/Articles/1175671/Getting-Started-with-MonoGame-using-Visual-Studio) for creating the final build of your game. I've included an archive with the extra project files required for VS 2017 that can be tweaked to fit your needs further.

## MonoGame Documentation

Main: http://www.monogame.net/documentation/
Alternate: https://jjagg.github.io/MonoGame-docfx/manual/

That should be all you need to get started. Happy game making!