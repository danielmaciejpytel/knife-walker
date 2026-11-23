<p align="center">
  <img src="Assets/Graphics/knife_walker_logo.png" alt="Knife Walker — pixel-art street with the neon PATMORTE pharmacy sign and the detective Ryan" width="720">
</p>

<p align="center"><b>A short cyber-noir point-and-click adventure in pixel art.</b><br>
A 2D adventure inspired by Blade Runner and classic noir detective stories, built in Unity with the Adventure Creator toolkit.</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-6000.3-F2B705?style=for-the-badge&labelColor=2A2B36" alt="Unity 6000.3">
  <img src="https://img.shields.io/badge/genre-point--and--click-E6199A?style=for-the-badge&labelColor=2A2B36" alt="Genre: point-and-click">
  <img src="https://img.shields.io/badge/art-2D%20pixel%20art-12A8B8?style=for-the-badge&labelColor=2A2B36" alt="Art: 2D pixel art">
  <img src="https://img.shields.io/badge/status-early%20demo-F2B705?style=for-the-badge&labelColor=2A2B36" alt="Status: early demo">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/requires-Adventure%20Creator-2A2B36?style=flat-square&labelColor=2A2B36&color=E6199A" alt="Requires: Adventure Creator (included in the repository)">
</p>

<p align="center">
  <a href="README.pl.md">Polski</a> · <b>English</b> ·
  <a href="#quick-start">Quick start</a> ·
  <a href="#screenshots">Screenshots</a> ·
  <a href="#features">Features</a> ·
  <a href="#about-this-repository">About this repository</a> ·
  <a href="#authorship-and-licences">Authorship and licences</a>
</p>

Knife Walker is an early demo scene that shows the basic mechanics and interactions of the game: you play Ryan, who has lost three fusion engine parts and has to find them to rebuild his car engine.

## Quick start

There is no packaged build or GitHub release yet, so the game runs from source in the Unity editor.

1. Clone or download this repository.
2. Install the Unity editor version listed in [`ProjectSettings/ProjectVersion.txt`](ProjectSettings/ProjectVersion.txt) (add the project in Unity Hub and let it pick that version).
3. Open the project folder and wait for the first import to finish.
4. Open the scene [`Assets/Scenes/gameplay.unity`](Assets/Scenes/gameplay.unity) and press **Play**.

## Screenshots

![Ryan on the rooftop describing his problem: three lost fusion engine parts](Assets/GitHub/screenshot_001.png)

<table>
  <tr>
    <td><img src="Assets/GitHub/screenshot_002.png" alt="Ryan looking at his car and commenting on it" width="100%"></td>
    <td><img src="Assets/GitHub/screenshot_003.png" alt="Ryan in front of the closed PATMORTE pharmacy, with his spoken line shown as a subtitle" width="100%"></td>
  </tr>
  <tr>
    <td><img src="Assets/GitHub/screenshot_004.png" alt="The street in front of the PATMORTE pharmacy with a hotspot label over the trash can" width="100%"></td>
    <td><img src="Assets/GitHub/screenshot_005.png" alt="Ryan beside his car with the Blue Engine Part selected in the inventory bar" width="100%"></td>
  </tr>
  <tr>
    <td><img src="Assets/GitHub/screenshot_006.png" alt="Pause menu with Resume, Options, Save, Load and Quit" width="100%"></td>
    <td><img src="Assets/Graphics/first_scene.gif" alt="Early animated recording of the first scene (GIF)" width="100%"><br><sub>Early recording of the first scene (GIF).</sub></td>
  </tr>
</table>

## Features

- **Pixel-art cyber-noir setting** — a yellow, neon-lit city with a retro look, drawn in pixel art.
- **Point-and-click interaction** — hotspots show their names (for example "Trash can") and the character comments on what he sees.
- **Dialogue and subtitles** — speech is shown in a pixel font with the speaker name.
- **Pause menu** — Resume, Options, Save, Load and Quit.
- **Eight-direction character animation** — idle and walk cycles for the main character.

## About this repository

The purpose of this repository is to preserve the game and keep it in a playable state on a modern version of the Unity engine. Main goals:

- Preserve the project as a milestone of my early development journey.
- Keep the game functional on newer versions of Unity.
- Maintain the retro aesthetic, blending pixel art with a cyber-noir atmosphere.
- Fix minor issues and polish core interactions for a smoother experience.

## Authorship and licences

Knife Walker is made by Daniel Maciej Pytel (the game art carries the signature DARKEZOWSKY).

Third-party content included in the repository:

- **Adventure Creator** — the adventure toolkit, including its demo content, in `Assets/AdventureCreator`. It remains under its own licence terms; several of its folders carry their own licence files (for example `music license.rtf` and `model license.rtf`).
- **Asset packs** in `Assets/Packs` — 44.1 General Library (Free Sample Pack), Synthwave Music Pack and Thaleah PixelFont (see its `Thaleah_Readme.pdf`).

