[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)

# HW1

## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog

Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

Write your Devlog here!
HW1 Breakdown:
How would you describe this game world in objects?
Player, Seeds, Seeds UI

What attributes and actions do these objects have?
Player- sprite
movement (WASD), planting (Space)
Plants- sprite
prefab (quant: 5)
cannot move
appears upon pressing space
Seeds Planted UI- increased based on number of times space is pressed
Seeds Left UI- decreases based on number of times space is pressed

How do these objects act on or affect each other ?
Player sprite changes position based on player input keys,
Seeds appear based on the player’s position and pressing space,
UI changes based on number of times player plants using space

Devlog: HW1 was a helpful review of the topics we studied in GDIM31 last quarter. The in-class breakdown
we wrote for this assignment dissected the game world into objects, attributes, and actions. I started in player class as it is first on the breakdown list. To enable player movement, I wrote code to get WASD key inputs from the player to transform the sprite's position. I included this in the Update function because the player movement is an action that should be tracked every frame of the game. I worked on the PlantSeed method in the player class so that it could instantiate according to the player sprite's position. In PlantSeed, I wrote code to adjust the number of seeds planted/left when a new prefab is spawned and also call the UpdateSeeds method to update the UI accordingly. Back in the Update function, I called the finished PlantSeed method when space is pressed. The breakdown includes plants as limited to 5, so I wrote an if statement for PlantSeed to be called only when there are seeds available. For the UI part of the breakdown, TextMeshPro is used in the code and scene to display the plants planted and left based on the game state.

Although the code and breakdown I wrote was very similar, one difference is that the breakdown lists the UI increasing/decreasing based on inputting space. This feature was not written in the UI class but rather the Player class PlantSeed method. It proceeds the instantiation of the plant prefab rather than being written with GetKey. The breakdown was a good skeleton for the assignment, but not an exact one-to-one.

## Open-Source Assets

If you added any other outside assets, list them here!

- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
