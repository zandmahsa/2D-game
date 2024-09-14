# The Leftovers - 2D Game (Working Title)

## Game Overview

**The Leftovers** is a 2D platformer developed using the Unity game engine, designed to challenge players with a range of enemies, obstacles, and environmental hazards. The objective is to navigate through dangerous environments, collect coins, and defeat enemies while avoiding traps and falls.

### Key Features:
- **Player Controls**:
  - Arrow keys for movement (left and right).
  - Spacebar for jumping.
  - Left mouse button for shooting bubbles to destroy enemies.

- **Enemies & Obstacles**:
  - Giants require two bubble hits to be defeated.
  - Zombies send the player back to the start upon collision.
  - Spikes decrease the player's health, but collectible hearts restore it.

- **Game Mechanics**:
  - Collect coins scattered throughout the level. Gold chests provide 10 coins.
  - Teleportation through certain buildings allows players to advance, though returning after entering can lead to challenges.
  - Falling off platforms results in a game over.

- **Health & Power-ups**:
  - The player starts with three hearts, and additional hearts can be found throughout the level.

Despite having only one level, the difficulty and variety of challenges provide an engaging and entertaining experience.

> **Note**: All sprites used in the game were sourced from [CraftPix](https://craftpix.net/).

---

## Development Details

The environment was created using Unity’s **Tilemap** and **Tile Palette** tools, with colliders applied to ground tiles and friction adjusted through material settings. Layers and tags were used to manage different objects in the game, including player interactions with the environment.

### Player Mechanics & Animations
The player character is designed with smooth movement and jumping mechanics. Early challenges with sliding were addressed by fine-tuning the physics via custom scripts. Animations for walking, jumping, and attacking were added to enhance gameplay immersion.

### Collectibles & Scoring System
Coins and chests were implemented to give players objectives as they progress through the level. The chest object was scripted to provide additional rewards, and a sound effect was added to enhance the feedback for collecting items.

### Camera & Object Layering
Camera movement was optimized using custom scripts to follow the player's movement while maintaining smooth transitions. The **Sprite Renderer** was used to layer the background, player, and other objects, ensuring visual clarity and an organized layout.

### Health System
A health system was integrated into the game, with the player starting with three hearts. The system reduces health upon collisions with enemies or traps, while hearts scattered throughout the level allow for health recovery. This mechanic is managed through the **Game Controller** script.

### Enemy Behavior & Combat
Enemy characters, including **giants** and **zombies**, were scripted with distinct behaviors. Giants require two hits to be defeated, while zombies cause the player to restart the level. Custom animations and particle effects, such as a blood splatter on collisions, were incorporated to enhance the visual experience.

### User Interface (UI)
The game features a simple, intuitive UI to display the player’s coin count and health status. The menu system includes a **Main Menu** and a **Help Menu** created using Unity’s UI tools, with buttons linked to appropriate in-game actions via scripts.

### Prefabs & Reusability
Prefabs were created for all major game objects, including the player, enemies, and collectibles, allowing for easy expansion and reuse across the game. This modular approach ensures flexibility for future updates or additional levels.

### Teleportation & Other Game Mechanics
Special objects like teleportation buildings were introduced to provide players with a method of advancing through the game. The teleportation system is managed via scripts, offering dynamic progression while introducing new challenges.

---

## Assets & Visuals

Screenshots of various object settings, as well as detailed documentation, are available in the `Documents and Pictures` folder. These visuals provide insight into the design choices and technical configurations used throughout the development process.

---

## Conclusion

**The Leftovers** was developed to provide a challenging yet enjoyable 2D platforming experience. The project combines smooth player controls, dynamic enemy interactions, and engaging level design to create an immersive game. Despite some unresolved challenges in character animations and checkpoint systems, the final version offers a polished and exciting gameplay experience.

Feedback and suggestions are always welcome to help improve future iterations!

---

## How to Play
1. Clone or download this repository.
2. Open the project in Unity.
3. Run the game through Unity’s Play mode or export a build for external play.

Enjoy the adventure!
