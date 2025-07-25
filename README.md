# 2D Obstacle Avoidance Unity Game

This project is a 2D endless runner-style game built in Unity, where the player controls a bird and must avoid dynamically spawning obstacles. The game features both vertical and horizontal obstacles, increasing the challenge as the player progresses.

## Features

- **Player Control:** Guide a bird character through a scrolling environment.
- **Dynamic Obstacles:** Obstacles spawn at random positions and intervals, both vertically and horizontally.
- **Score Tracking:** The game tracks the player's score based on survival or obstacles passed.
- **Game Logic:** Handles game over conditions, scoring, and UI updates.
- **Boundaries:** Defines the playable area and detects out-of-bounds events.

## Key Scripts

- `BirdScript.cs` — Handles player input and bird movement.
- `VerticalSpawnScript.cs` & `HorizontalSpawnScript.cs` — Manage timed spawning of obstacles.
- `VerticalMovement.cs` & `HorizontalMovement.cs` — Control obstacle movement.
- `ObstacleMiddleScript.cs` — Manages special obstacles or interactions in the center area.
- `boundaries.cs` — Detects when objects leave the playable area.
- `LogicScript.cs` — Manages scoring, game state, and UI.

## Getting Started

1. **Clone or Download** this repository.
2. **Open the Project** in Unity (recommended version: 2020.3 LTS or newer).
3. **Open the Main Scene** (usually found in the `Assets/Scenes` folder).
4. **Press Play** to start the game.

## Requirements

- Unity 2020.3 LTS or newer
- .NET Framework 4.7.1
- C# 9.0

## How to Play

- Use the assigned controls (see `BirdScript.cs`) to move the bird.
- Avoid all obstacles and stay within the boundaries.
- Survive as long as possible to achieve a high score.

---
