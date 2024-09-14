# 3D game

<h1>Game instructions and descriptions</h1>
We created a 2D game called "The Leftovers" **I should change the name** using the Unity game engine. 

Upon launching the game, a menu will appear with instructions available in the help section.

Playing the game is easy. Use the arrow keys to move left or right and the spacebar to jump. 

Use the left mouse button to shoot bubbles that will destroy the giants. 

There is no limit to the number of bubbles that can be shot, but it takes two shots to destroy a giant. 

Pay attention to warning signs in the game that signal the presence of zombies, giants, and other dangers.

In the game, you must collect coins to progress. 

Gold chests grant ten coins each. 

If you encounter zombies, you will return to the start of the game.

You'll also lose hearts if you hit spikes, but there are hearts to collect to replenish them. 

At the start of the game, you have three hearts, but more can be found throughout the game.


Buildings in the game can teleport you ahead, but be careful not to turn back upon entering one. 

Falling from the ground tiles will result in a game over.

Although there is only one level, the game is exciting and challenging enough to keep you entertained. Don't be fooled by its apparent simplicity!


We downloaded the sprites used in this game from the https://craftpix.net/ website 



<h1>Description of the project construction process</h1>

In short, first we created the environment using tilemaps and the tile pallete window (also we created a clider for the ground and material to create and adjust the friction).

We used tags for the ground and the player, we also gave a name to the ground layer so that we can use it in scripts.

Then we set up the player and create animations and start coding for the player to move and jump. The player's problem was that it was slipping, and we solved this problem in the code by adding the desired scripts to find the player's physics and access the player's position and move it.

After completing the initial steps for collecting coins, we wrote a code for the chest, then we decided to include collecting hearts in our project.

We had some challenges with the camera movement and decided to add two separate scripts, one to control and obtain the player's location and the other to move and follow the player.

We changed the order of placing the objects in the layers of the game using sprite renderer so that the background, player and other objects are organized and the background is placed in the last layer.

We considered three hearts for the player, which can be seen in the Scrip game controller, and after each hit, the player's heart object decreases.

After finishing the work of the player, we prepared a prefab of the player, and then proceeded to prepare prefabs of other game objects, such as giants, coins, etc., so that we can expand the environment.

To destroy the character, we made a blood mode using the particle system, which is executed after every encounter with zombies. 
In the zombie script, we put a code to go and back, and in another script, we specified what point it should return to after hitting a zombie, and also how to give blood to the script to be displayed after the collision.

We made scripts for teleport and other things.
We added another object called bubble for the player so that he can destroy the giants with it. We wrote the attack script in the C# player file.

We created a canvas to display the coins and hearts, we also created a sound for coins, spikes, hearts and shots.

Using UI and Text Mesh Renderer, we created a menu in a new scene. We divided the menu into two sections, the main menu and the help menu, and using settings and scripts, we determined what would happen and what would be displayed by clicking on each button.



<h1>Documents and Pictures folder</h1>
We didn't know that it is necessary to share all the steps of making the game with you, but inside the Documents and Pictures folder, we put pictures of the settings of all the objects in the game. Unfortunately, at the last minute, we decided to change the part of the project that was related to checkpoints.

Anyway, we enjoyed making the game with all the challenges we had. We had many challenges in the animation for characters, coins, and giants, and still some challenges remain unsolved. I hope you enjoy playing our game.:)
