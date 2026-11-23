<p align="center">
  <img src="Assets/Graphics/knife_walker_logo.png" alt="Knife Walker — pikselartowa ulica z neonowym szyldem apteki PATMORTE i detektywem Ryanem" width="720">
</p>

<p align="center"><b>Krótka przygodówka point-and-click w pikselartowym stylu cyber-noir.</b><br>
Dwuwymiarowa przygodówka inspirowana Blade Runnerem i klasycznymi kryminałami noir, zbudowana w Unity z użyciem zestawu Adventure Creator.</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-6000.3-F2B705?style=for-the-badge&labelColor=2A2B36" alt="Unity 6000.3">
  <img src="https://img.shields.io/badge/gatunek-point--and--click-E6199A?style=for-the-badge&labelColor=2A2B36" alt="Gatunek: point-and-click">
  <img src="https://img.shields.io/badge/grafika-2D%20pixel%20art-12A8B8?style=for-the-badge&labelColor=2A2B36" alt="Grafika: 2D pixel art">
  <img src="https://img.shields.io/badge/status-wczesne%20demo-F2B705?style=for-the-badge&labelColor=2A2B36" alt="Status: wczesne demo">
</p>

<p align="center">
  <img src="https://img.shields.io/badge/wymaga-Adventure%20Creator-2A2B36?style=flat-square&labelColor=2A2B36&color=E6199A" alt="Wymaga: Adventure Creator (dołączony do repozytorium)">
</p>

<p align="center">
  <b>Polski</b> · <a href="README.md">English</a> ·
  <a href="#szybki-start">Szybki start</a> ·
  <a href="#zrzuty-ekranu">Zrzuty ekranu</a> ·
  <a href="#funkcje">Funkcje</a> ·
  <a href="#o-repozytorium">O repozytorium</a> ·
  <a href="#autorstwo-i-licencje">Autorstwo i licencje</a>
</p>

Knife Walker to wczesna scena demonstracyjna pokazująca podstawowe mechaniki i interakcje gry: wcielasz się w Ryana, który zgubił trzy części silnika fuzyjnego i musi je odnaleźć, żeby odbudować silnik swojego samochodu.

## Szybki start

Nie ma jeszcze gotowej paczki ani wydania na GitHubie, więc grę uruchamia się ze źródeł w edytorze Unity.

1. Sklonuj lub pobierz to repozytorium.
2. Zainstaluj wersję edytora Unity podaną w [`ProjectSettings/ProjectVersion.txt`](ProjectSettings/ProjectVersion.txt) (dodaj projekt w Unity Hub, a wskaże on tę wersję).
3. Otwórz folder projektu i poczekaj na zakończenie pierwszego importu.
4. Otwórz scenę [`Assets/Scenes/gameplay.unity`](Assets/Scenes/gameplay.unity) i naciśnij **Play**.

## Zrzuty ekranu

![Ryan na dachu opisuje swój problem: trzy zgubione części silnika fuzyjnego](Assets/GitHub/screenshot_001.png)

<table>
  <tr>
    <td><img src="Assets/GitHub/screenshot_002.png" alt="Ryan patrzy na swój samochód i komentuje go" width="100%"></td>
    <td><img src="Assets/GitHub/screenshot_003.png" alt="Ryan przed zamkniętą apteką PATMORTE, z wypowiedzią pokazaną jako napis" width="100%"></td>
  </tr>
  <tr>
    <td><img src="Assets/GitHub/screenshot_004.png" alt="Ulica przed apteką PATMORTE z podpisem hotspotu nad śmietnikiem" width="100%"></td>
    <td><img src="Assets/GitHub/screenshot_005.png" alt="Ryan obok swojego samochodu z przedmiotem Blue Engine Part wybranym na pasku ekwipunku" width="100%"></td>
  </tr>
  <tr>
    <td><img src="Assets/GitHub/screenshot_006.png" alt="Menu pauzy z opcjami Resume, Options, Save, Load i Quit" width="100%"></td>
    <td><img src="Assets/Graphics/first_scene.gif" alt="Wczesne animowane nagranie pierwszej sceny (GIF)" width="100%"><br><sub>Wczesne nagranie pierwszej sceny (GIF).</sub></td>
  </tr>
</table>

## Funkcje

- **Pikselartowy świat cyber-noir** — żółte, oświetlone neonami miasto w retro stylu, narysowane w pixel arcie.
- **Sterowanie point-and-click** — hotspoty pokazują swoje nazwy (na przykład „Trash can”), a postać komentuje to, co widzi.
- **Dialogi i napisy** — kwestie wyświetlane są pikselową czcionką razem z imieniem mówiącego.
- **Menu pauzy** — Resume, Options, Save, Load i Quit.
- **Animacja postaci w ośmiu kierunkach** — cykle postoju i chodzenia głównego bohatera.

## O repozytorium

Celem repozytorium jest zachowanie gry i utrzymanie jej w stanie umożliwiającym grę na nowoczesnej wersji silnika Unity. Główne cele:

- Zachowanie projektu jako kamienia milowego mojej wczesnej drogi w tworzeniu gier.
- Utrzymanie działania gry na nowszych wersjach Unity.
- Podtrzymanie retro estetyki łączącej pixel art z atmosferą cyber-noir.
- Poprawianie drobnych błędów i dopracowywanie kluczowych interakcji, aby gra działała płynniej.

## Autorstwo i licencje

Knife Walker stworzył Daniel Maciej Pytel (grafika w grze nosi podpis DARKEZOWSKY).

Zawartość zewnętrzna dołączona do repozytorium:

- **Adventure Creator** — zestaw do tworzenia przygodówek wraz z materiałami demonstracyjnymi, w `Assets/AdventureCreator`. Obowiązują go jego własne warunki licencyjne; kilka jego folderów ma własne pliki licencji (na przykład `music license.rtf` i `model license.rtf`).
- **Paczki zasobów** w `Assets/Packs` — 44.1 General Library (Free Sample Pack), Synthwave Music Pack i Thaleah PixelFont (zob. `Thaleah_Readme.pdf`).

