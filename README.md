# AtlusMSGEditor
![](https://i.imgur.com/D94QM9r.png)
This program allows you to create and organize text editing projects for Persona games.  

# Notice
**Currently, only P5R (PC/Switch) is supported**. Support for other games will be added in the future.

# Features
- Load a default text dump from ``./Dependencies/MsgDirs.json`` on startup
- Save/load your edits as a shareable ``.json`` for easy backup and collaboration
- You can search the dump for a string, with the option to limit your search to the file, directory, or entire dump
- Add terms to the auto-replace list and they will be replaced in speaker/message text automatically (uses regex, so do ``\bYOURWORDHERE\b`` to match whole word)
- Import all ``.BF``/``.BMD`` extracted from your game dump. It'll be automatically decompiled to the ``./Dump`` folder (including files in PACs)
- Export your dump to the ``./Output`` folder as a ``.json`` to use at startup, or as a pair of ``.txt`` files containing all the dumped flowscript and messagescript
- Export your changes as brand new ``.BF``/``.BMD`` in the ``./Output`` folder (``.PAC``s are not repacked yet)
- Automatically inject edited ``.BMD`` into the ``.BF`` it originated from (requires you to import from your own dump since it uses ``.BF`` files from ``./Dump``)

# Configurable Settings
Note: Currently, these settings are not saved between sessions.
- Switch between light/dark theme
- Optionally skip compiling ``.msg`` to ``.BMD``/``.BF`` (in case you're using a Reloaded II add-on to compile on the fly)
- Optionally delete all ``.msg`` files from ``./Output`` when exporting your changes
- Optionally delete existing ``./Dump`` directory when importing a new game dump
- Optionally delete existing ``./Output`` directory when exporting new changes
- Optionally show which directories/files/messages are affected by Auto-Replace (this is disabled by default since it can be slow)
- Choose between "P5R_EFIGS", "P5R_JAPANESE" and "P5R_CHINESE" encoding

# Planned Features
The following features are just ideas for now and might appear in future releases.
- Repacking archives when exporting changed files originally contained within them (``.PAC``/``.BIN``)
- Support for dumps from other games
- Including ``.flow`` files in editor (either in a separate tab or alongside ``.msg``s with a filter option)
- Opening ``.flow``/``.msg`` files in Notepad++ for easier editing
- Adding/removing/renaming files, messages, or directories
- Setting notes for directories/messages/files for easier navigation

# Project Status
See [here](https://trello.com/c/9NuvNvOO/112-atlusmsgeditor) for the current completion status.  
The latest release can be found [here](https://github.com/ShrineFox/AtlusMSGEditor/releases).
