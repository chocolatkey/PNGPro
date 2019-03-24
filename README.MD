# PNGPro

A simple VB.NET wrapper for the oxipng CLI.
PNGPro makes it easy to optimize many files with `oxipng -4` by allowing you to drag and drop (or choose from the file chooser)
many PNGs and queue them for optimization.

There are no plans to make this program complex, it is simply a way to run `oxipng -r *.png` for less technical users

## Usage

Go to the [releases page](https://github.com/chocolatkey/PNGPro/releases) and download the attached SFX executable. It includes the latest release (currently v2.2.0) of oxipng.
The GUI should be self-explanatory, drop PNGs on the program, or choose them with the "Add Files" button. Start and stop the optimization process with the second button.

If you want to build the program yourself, just open it up in Visual Studio, build it, and place it in the same directory as oxipng.exe.