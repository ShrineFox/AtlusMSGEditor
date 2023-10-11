# AtlusMSGEditor
![](https://i.imgur.com/ur1nn2p.png)  
Create and organize text editing projects for Persona games

# Notice
This program allows you to create and organize text editing projects for Persona games.  
It's currently in beta and missing features that would make it usable for an actual project. For now, you can at least create and manage project files. The full release build will allow you to load your project and export your changes to .bf/.bmd.  

# Features
- Loads default text dump from P5R (PC, English) from ./Dependencies/MsgDirs.json
- You can save/load changes as a project .json (can't export to .bmd/.bf yet, will be added in release version)
- You can search the txt dump for a string
-- Narrow down whether the search includes other files or directories using the checkboxes
-- Search results include message name, message text, or speaker text
-- Search results include both changes and the original message
- Add terms to the auto-replace list and they will be replaced in speaker/message text automatically

# Disabled Features
For now, I've removed the following options since they either don't work correctly or haven't been implemented yet.  
They should appear in the full release.
- Importing .BF/.BMD text from the game's extracted CPK files
- Exporting dump as flow/msg .TXT files
- Creating a .json of the MSG dump to load by default (like the supplied P5R one)
- Exporting changes as edited .bf/.flow files

# Planned Features
The following features are just ideas for now and probably won't appear in the first full release.  
- Including .flow files in editor (either in a separate tab or alongside .MSGs with a filter option)
- Opening .flow/.msg files in Notepad++ for easier editing
- Adding/removing/renaming files, messages, or directories
- Setting notes for directories/messages/files for easier navigation
- Show files affected by auto-replace (if a fast enough way to check is possible)
- Instantly show files affected by user changes without having to reselect?
- Support for other games

# Project Status
See [here](https://trello.com/c/9NuvNvOO/112-atlusmsgeditor) for the current completion status.  
The beta release can be found [here](https://github.com/ShrineFox/AtlusMSGEditor/releases).
