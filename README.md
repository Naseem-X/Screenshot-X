<p align="center">
  <img src="assets/icon.png" alt="Screenshot-X icon" width="120" height="120">
</p>

<h1 align="center">Screenshot-X</h1>

<p align="center">A lightweight, All-In-One Screenshot And Screen Recording Tool for Windows (10,11), built with C# WinForms.</p>

![Version](https://img.shields.io/badge/version-1.2-blue)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![License](https://img.shields.io/badge/license-MIT-green)

## Features

### 📸 Screenshots
- **Window / Region capture** — snip any part of your screen
- **Full screen capture** — instant full-display screenshot
- **Freeform capture** — draw a custom-shaped selection
- Auto-saves to a configurable folder (default: `Pictures/Screenshot-X`)
- Copies directly to clipboard
- OCR text extraction (English + Arabic) from any screenshot
- Built-in color picker with hex code copy

### 🎥 Screen Recording
- Record your full screen with system audio and microphone
- **Pause / Resume** recording mid-session
- **Countdown timer** before recording starts (customizable duration)
- Mute/unmute microphone and system sound independently — even mid-recording
- Configurable output resolution (System / 1080p / 720p / 480p)
- Auto-saves to a configurable folder (default: `Videos/Screenshot-X`)

### 📷 Webcam Overlay
- Live webcam preview while recording, fully draggable and resizable
- Custom size presets (Small / Medium / Large / Custom)
- Circular or rounded-corner camera frame with adjustable border radius
- Toggle camera on/off without interrupting your recording

### ⚙️ Quality of Life
- Global hotkeys for every major action (fully customizable modifiers)
- Remembers your last window position, screenshot mode, and all recording preferences between sessions
- Runs quietly in the system tray with live status icons
- Smooth fade/slide animations throughout the UI
- "What's New" popup on updates

## Hotkeys

### Main App
| Action | Hotkey |
|---|---|
| Show / Hide App | `Alt + L` |
| Take Screenshot | `Alt + S` |
| Screenshot Mode Settings | `Alt + M` |
| OCR (Extract Text) | `Alt + O` |
| Color Picker | `Alt + C` |
| Open Screen Recorder | `Ctrl + Alt + S` |
| Quit App | `Alt + Q` |

### Screen Recording Tab
| Action | Hotkey |
|---|---|
| Start / Stop Recording | `Alt + V` |
| Pause / Resume | `Alt + P` |
| Toggle Camera | `Alt + K` |
| Toggle Microphone | `Alt + U` |
| Toggle System Sound | `Alt + Y` |
| Recording Settings | `Alt + R` |
| Exit Recording Tab | `Alt + E` |

## Installation

1. Download the latest installer from the [Releases](https://github.com/Naseem-X/Screenshot-X/releases) page
2. Run `Screenshot-X-Setup.exe`
3. Launch Screenshot-X from the Start Menu — it will minimize to your system tray

> **Note:** Screenshot-X requires the [Visual C++ Redistributable (x64)](https://aka.ms/vs/17/release/vc_redist.x64.exe) for screen recording to work. Most Windows systems already have this installed.

## Built With

- **C# / .NET Framework (WinForms)**
- [Guna.UI2](https://github.com/Guna1997/Guna.UI2) — modern UI controls
- [Tesseract](https://github.com/charlesw/tesseract) — OCR engine
- [ScreenRecorderLib](https://github.com/sskodje/ScreenRecorderLib) — screen recording engine
- [AForge.NET](https://github.com/andrewkirillov/AForge.NET) — webcam capture

## Author

Made by **LQNS-X**
GitHub: [@Naseem-X](https://github.com/Naseem-X)

## Support the Project

If you find Screenshot-X useful, consider supporting development:
[PayPal](https://www.paypal.com/paypalme/NaseemAbuAlShaikh)

## License

This project is licensed under the MIT License.
