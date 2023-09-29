# monogame-vscode-boilerplate

A MonoGame C# configuration for Visual Studio Code

## Prerequisites

* [.NET 6.x +](https://dotnet.microsoft.com/download)
* [Visual Studio Code](https://code.visualstudio.com/download)
  * [Official C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
* [MonoGame 3.8.1+](http://www.monogame.net/downloads/)

## Instructions

Install the above and open this folder in VS Code. Run one of the tasks with Ctrl+Shift+B (or Cmd+Shift+B on Mac). This simply uses the dotnet CLI now, where everything is pretty straightforward. At the moment, it's the same template as running `dotnet new mgdesktopgl -o MyGame` with tasks.json for Release and Debug, but cs files are expected in the `src/` folder, and platform-specific build files were moved to `platform/`.

## MonoGame Documentation

Main: http://www.monogame.net/documentation/

That should be all you need to get started. Happy game making!