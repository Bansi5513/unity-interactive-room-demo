# Unity Interactive Room Demo

A Unity room scene with a first person flying camera, a rotating ceiling fan, and a light switch that changes the color of the room light.

## Demo
[Watch the demo video](xr_interaction_demo.mp4)

## Features
- Furnished room with a table, chair, wall shelf, blackboard, plants, and objects on the table
- Ceiling fan that rotates continuously
- Light switch: walk up to it and press F to cycle the room light through five colors
- Flying camera with keyboard and mouse controls
- Warm table lighting and floating particles

## Controls
- W A S D: move
- Q / E: move down and up
- Mouse: look around
- F: change the light color when near the light switch

## Project Structure
- `Assets/Scripts/FanRotate.cs`: rotates the ceiling fan
- `Assets/Scripts/LightSwitch.cs`: changes the room light color when the player is nearby
- `Assets/Scripts/FlyCamera.cs`: camera movement and mouse look
- `Packages/manifest.json`: Unity packages used by the project

## Built With
Unity [your version], C#

## Note
This repository contains the scripts and a demo video. The full Unity project is not included because of file size limits.
