# Unity-PlayFromScene
A simple editor utility for Unity so you can define a scene to start from when you hit the play button. When you exit playmode, it will go back to whatever scene you had open. This allows for an easy workflow if you have an init/splash scene that loads stuff for the game to work. Since this scene is defined by the engine before playmode starts, it will not cause errors when you start play mode. It will also automatically disable so your players don't see this script.

# How do I add this to my project?
For now, simply download the file and put it in your Assets/Editor folder. A Unity Package will be made later. 

# How to use
Go to StartupScene.cs and add in the path of the scene you want to launch from and the build index. Once your scripts compile, the engine will now go to that scene.

# How do I disable it?
Simply comment out the first line so it is now //#define ENABLE_STARTUPSCENE . This will disable the behaviour when your scripts recompile.

# How will this be updated?
I plan to add a proper editor window to this so there is no messy code editing. My needs for this script just don't require it exactly so I haven't needed to yet.

I will also properly update this repository in the future to actually have substance and a Unity Package.

# Do you have any license requirements?
Just MIT license. As far as I'm concerned, you can freely use and update this, with or without attribution. Go wild.

# Can I contribute?
Yes, especially once I set up a contributing file. It's pretty simple so any integrations or additional features will be helpful. For now, just fork and open a pull request when done.
