# Shattered_Reality



## Latest Realease 
Download Shattered_Reality.exe to start playing!
 
[Link](/Unexpected-Error/Shattered-Reality/releases/latest/download/WindowsClient.zip) to download the latest release 
#### Dependencies
 - Steam

## Description
Shattered Reality is a WIP firstperson shooter. As the features that make this game distinict are not yet, it currently is in the form of a generic FFA shooter. Being of the FFA type gamemode, at the end of a match, the person with the most kills wins

#### Current Features

* Main menu
	* Server Browser/creator

<img src="/images/MainMenu.PNG" width="400">
<img src="/images/ServerBrowser.PNG" width="400">
<img src="/images/ServerCreation.PNG" width="400">
<img src="/images/ServerCreationOptions.PNG" width="200">

* HUD
	* Game Timer
		* Game ends when timer runs out
	* Health bar
	* Ammo & Reserve ammo counter 

<img src="/images/hud.PNG" width="400">
<img src="/images/Timer.PNG" width="400">
<img src="/images/Ammo.PNG" width="400">

* pause menu

* Damage system
	* Take damage
	* Respawn

* Win/Loss
	* Win loss screan after game ends
	* Winner is the one with the most kills
	* Returned to menu after game ends


## Running your own server
Get Shattered_RealityServer.exe, and launch on the command line using arguments to modify behavior
#### Argumements (case insensitive) (use like -option=arg)
| Argument           | Effect | Default |
|--------------------|--------|---------|
|`-log`              |shows server log events|No log|
|`-name`             |Changes Server name|Defaultname|
|`-mapname`          |Selects a map to join| :warning:Default value is DefaultLevel, which does not exist:warning:|
|`-maxplayers`       |limits how many people can join any given server|10|
|`-startplayercount` |changes at what player count the game begins|2|
|`-gamelength`       |Change length of game in seconds| 30 sec|


#### Levels availible to run on server

| Level Name | In game name | Desc |
|------------|--------------|------|
|`Gamelevel`| \[WIP\] Empty Plane | 2x1 empty plane, with one spawn near the corner. Used as test map|


## Known bugs

1. Server does not show up across the web
2. If client acts as server, that client has a messed up HUD
3. Server detection inconsistent 
