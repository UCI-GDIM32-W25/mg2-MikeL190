[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
The plan I built in the MG2 break-down activity ended up being the foundation for my game. The Penguin was the GameObject that would represent the user, and I used a script called Player_Controller to handle the Jump and IsTouchingCoin actions that I originally planned. The Coins also followed my plan because they have the Coin_Logic script attached to them which handles their Movement. I still included the DestroySelf idea that I presented in the break-down activity, it's just that it's contained inside the Player_Controller script. For the UI interface, I created a script called UI_Manager that has the UpdateText() method I originally came up with to keep the score updated on the screen.
<br> <br>
However, my plan changed a bit once I actually started coding because I realized I needed more logic to make the game work smoothly. For example, I added a Game_Controller script that wasn't in my original plan. I used a Coroutine inside that script to handle spawning the coins at random times, which made the game feel more natural. In the Player_Controller, I also had to change the jump logic so the penguin can only jump when touching the ground, otherwise, the player could just fly forever. I also decided to add an 8-second timer to the coins so they would destroy themselves if the player missed them, which keeps the game from lagging. Finally, adding a background object meant I had to spend some time figuring out the rendering and layers so the penguin wouldn't disappear behind the scenery. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
