# HW4
## Devlog

In this game, I utilized the model-view-control pattern by keeping my Player Class, PipeSpawner Class, AudioManager Class, and UI Class separate from each other by using a locator. The Player Class and PipeSpawner Class represents the Control side of the pattern, with Player responsible for handling the player input and triggering events, and PipeSpawner handling the spawn rate and location of the pipes for the player to avoid. The AudioManager and UI Classes represent the View side of the pattern, as they are responsible for playing the correct audio and updating the UI to depict the current score or if the player has died. They do this by responding to the correct events triggered by the Player Class, using a singleton to locate the correct event without needing to reference the player script directly. For example, in my AudioManager Class, it assigns the BirdJumped Event called by the player class to the PlayJumpAudio() method through the line "Locator.Instance.Player.BirdJumped += PlayJumpAudio;", which uses the Locator Instance to find the Player object.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - jump sound effect
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [Kenneys music jingles](https://kenney.nl/assets/music-jingles) - points gained sound effect