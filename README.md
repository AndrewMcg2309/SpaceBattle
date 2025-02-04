# SpaceBattle
Assignment 2 - Games Engine 2

Battlestar Galactica Space Battle
https://www.youtube.com/watch?v=PqV2Ncxe8Ak&ab_channel=IllustratedFiction

Each of these scenes were separated and changed by a script that allows the time of each scene to be input and moves it to the next scene.
Some scenes to note for behaviours are scene 2, 3, 4 End scene.
There is also a video of this in action in case there are issues with the sound not macthing. The video is located in the main folder

Here is the video of my creation:
https://www.youtube.com/watch?v=Z3A5qt4xfqo&ab_channel=AndrewMcgowan

## Items from Asset Store used:
- Cobble Games
- F3_corvette
- Gamer Squid
- HiRezSpaceshipCreatorFree
- SF_Fighter
- SpaceSkies Free
- StarSparrow

## Behaviours used:
- Jitter behaviour
- Rotating behaviour
- Follow behaviour
- Wandering behaviour
- Multiple different camera movement behaviours
- Direct behaviours
- Different turret behaviours

## Classes I wrote myself:
- ALL classes in camera rotation folder 
- ALL classes in turret folder 
- SoundClass class
- Spawn class
- MoveStraight class
- Rotate class
- RotateShip class
- RotateTurret class

## Classes from other sources:
- Cruiser class (boid) : https://github.com/skooter500/GE2-2020-2021
- Jitter Wander : https://github.com/skooter500/GE2-2020-2021
- SteeringBehaviour class : https://github.com/skooter500/GE2-2020-2021
- FollowPath class : https://github.com/skooter500/GE2-2020-2021
- Persue class : https://github.com/skooter500/GE2-2020-2021
- Planet classes : https://github.com/SebLague/Procedural-Planets

## Garphical Techniques
#### Particle Systems
- Particle system for turrets, 
- Shots fired between two ships in scene 9 
- Large particle system used to represent the fog / mist in scene 1
- Particle system in final scene as the ship begins to jump
- Missiles in final scene have a trails that were created by a particle system
- Credit scene is inside a particle system

#### Trail Renderers
- Trail renderers added to enemy fighters 

#### Other visuals
- Turrets movement when shooting done from coroutines and behaviour code along with particle system
- The design of the ships from the asset store have been modified by myself to add turrets, change looks and also colors
- There are no hardcoded behaviours for and ships, all either doing a behaviour or moving forward, there was no movement from set point to set point.

# Storyboard:

## Scene 1
#### Camera
 - Camera slightly drifting 
#### Behaviours
- Ships to move in straight line with one rotating around itself to give twisting visual
- All straight line directional 
#### Display
- Fog in background for misty planet in video
 
## Scene 2
#### Camera
- Camera moves along with ships then does a close up to the turning ship by changing the position of the camera over time set by a coroutine.
#### Behaviours
- Ship turns on a scale to have the top facing the enemy
- Other ships moving in straight line
#### Display
- Ships moving alongside each other towards the enemy ship

## Scene 3
#### Camera
- Moves with turrets
#### Behaviours
- Turrets rotate up and out to face the enemy
#### Display
- Turrets used from asset store added to spaceship from separate package 

## Scene 4
#### Camera
- Camera moves with turret and the uses "LookAt" to face the enemy ship and then zooms in at the ship
#### Behaviours
- Turrets rotating like previous scene
- Swarm behaviour of all the enemy fighters
#### Display
- Turrets rotating out and lots of enemy ships with the mother ship behind it

## Scene 5
#### Camera
- Camera now at enemy ship facing down
#### Behaviours
- Swarm behaviour of all the enemy ships
#### Display
- All the enemy ships move down towards ship in swarm-like movements 

## Scene 6
#### Camera
- Camera moves slowly
#### Behaviours
- Turret’s firing using particle systems 
#### Display
- Turrets firing at a high rate

## Scene 7
#### Camera
- Slow movement of camera
#### Behaviours
- Large turrets on timed fire with timed movement of the shot recoil
#### Display
- turrets firing large shots towards enemy

## Scene 8
#### Camera
- Slow movement of camera
#### Behaviours
- Large turrets on timed fire with timed movement of the shot recoil
#### Display
- Different angle of scene 6 with turrets firing at enemy 


## Scene 9
#### Camera
- Distance away from the two ships as they fire at each other
#### Behaviours
- Both ships still with two particle systems to replicate shots
#### Display
- All the shots being fired from both sides with big wide view 

## Scene 10
#### Camera
- Camera slowly turning upward
#### Behaviours
- Ship moving forward out of mist
#### Display
- Main ship still firing up at the enemy while another ship comes out of the mist

## Scene 11
#### Camera
- Focus on turret and then moves backwards with the rockets and stops when it explodes
#### Behaviours
- Turret fire on time with camera movement 
#### Display
- Movement of camera makes it seem the missiles are moving alongside it and then blows up with particle system

## Scene 12
#### Camera
- Random movement to show chaos 
#### Behaviours
- Particle systems firing left and right with movements from the enemy fighters 
#### Display
- Chaos
- Explosions, missiles firing and ships flying

## Scene 13 - Final Scene
#### Camera
- Camera looks down at the ship 
#### Behaviours
- Enemy ships move with following behaviour to the furthest one ahead
- 2 groups of following behaviours 
- Ship still and disappears in a jump 
#### Display
- Ship disappears into hyperspace with particle system to represent the movement
- Missiles falling down along with enemy ships

## Credit Scene

