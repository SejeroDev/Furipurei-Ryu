The only updated languages ​​are English and Spanish.

As of now, the **Furipurei Ryu Edition** repository serves as a continuation of the original Ryujinx project. For the time being, this project won't be accepting any new *major* changes until further information arises. We have reconstructed the essential build infrastructure, and you can download nightly binaries for Windows, Linux, and macOS from the latest release.

> **Note:**  
> This project is not affiliated with the **original** Ryujinx project, or Nintendo in any way.

### Current Goals

* ☑️ Reconstruct the basic build infrastructure & workflows for this repository, using revision hashes instead of semver releases (for now).
* ☑️ Ensure full attribution of original authors and contributors, while removing all references to the previous in-app systems, such as Patreon, original domain, etc.
* Keep the project's 'branding' as close to the original Ryujinx as possible.

### Compatibility

As of October 2024, Furipurei Ryu Edition has been tested on over 4,300 titles; more than 4,100 boot past menus and into gameplay, with roughly 3,550 of those considered playable.

Anyone is free to submit a new game test or update an existing entry by following the test submission guidelines.

### Usage

To run this emulator, your PC must have at least 8GB of RAM; failing to meet this requirement could result in poor performance or crashes.

### Latest Build

These builds are automatically compiled from each commit on the main branch. While we strive to ensure stability and performance, some builds may be unstable or broken.

### Building

If you wish to build Furipurei Ryu Edition yourself, follow these steps:

1. **Install the .NET 8.0 (or higher) SDK**:  
   Ensure your SDK version matches or exceeds the one specified in the `global.json` file.

2. **Clone the repository or download the zip file**:  
   Use `git clone` or download the files manually.

3. **Build the emulator**:  
   Open a terminal in the project directory, and run the following command:  
   `dotnet build -c Release -o build`  
   The build files will be found in the newly created `build` folder.

### Features

- **Audio**:  
  Supports audio output (but not input). Uses OpenAL and SDL2, with fallback support via libsoundio.

- **CPU**:  
  Furipurei Ryu Edition uses a CPU emulator that supports ARMv8, ARMv7 (partial), and legacy instructions. Performance is optimized using different memory management options, including host-mapped modes for faster execution.

- **GPU**:  
  The GPU emulator simulates the Switch's Maxwell GPU with support for OpenGL, Vulkan, and Metal. Furipurei Ryu Edition offers various graphics enhancements, such as resolution scaling, shader caching, and anti-aliasing.

- **Input**:  
  Full support for keyboard, mouse, JoyCons, and most game controllers, with motion control support through external tools.

- **DLC & Mods**:  
  Furipurei Ryu Edition can manage DLC, mods, and cheats through its GUI.

- **Configuration**:  
  The emulator offers flexible configuration options accessible via both the GUI and a `Config.json` file.

### License

Furipurei Ryu Edition is licensed under the terms of the MIT license. This project also incorporates code from third-party sources, which are documented in the license files.

### Credits

- **LibHac** for file-system emulation.
- **AmiiboAPI** for Amiibo emulation.
- **ldn_mitm** for multiplayer modes.
- **ShellLink** for Windows shortcut creation.
