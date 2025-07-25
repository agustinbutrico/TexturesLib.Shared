# TexturesLib.Shared for Rogue Tower

TexturesLib.Shared is a shared library mod that provides tools and utilities for Rogue Tower modders. It simplifies access to textures, colors, and contrast calculations, helping you build consistent and visually appealing UI elements or cards without reinventing the wheel.

## Installation

    Download the TexturesLib.Shared DLL.

    Place the .dll file into your BepInEx/plugins folder.

    Launch the game.

Note: This is a library mod and is primarily designed as a dependency for other mods rather than a standalone feature.

## Features

    Texture Lookup
    Easily find any sprite provided by a TexturesLib mod by its name.

    Color Utilities (ColorsHelper)
    Access a wide selection of custom colors for your UI or game elements.

    Contrast Colors
    Get automatic contrasting colors with ColorsHelper.GetContrastByName() to ensure good readability and visual consistency.

    Modding-Oriented
    Designed to be lightweight and compatible with other Rogue Tower mods. Ideal as a building block for UI mods, card visualizers, or other texture-related tools.

## Usage

Developers can reference TexturesLib.Shared in their mod projects to directly access ColorsHelper and other texture utilities.

## Example (C#):

using TexturesLib.Shared;
Color myColor = ColorsHelper.GetContrastByName("blue");