# Fruta Bird Game

<img src="docs/img/FrutaBird.gif" width="240" height="400" alt="Fruta Bird Gameplay">## Description

 In Fruta Bird, players take flight as the Serindit Melayu, the vibrant mascot of Riau. This 2D arcade experience brings my hometown of Tanjungpinang to life, challenging players to soar past local landmarks like the Tugu Gonggong located at Pelabuhan Sri Bintan Pura.

 Built with custom Inkscape graphics and precise Rigidbody2D physics, the game pairs smooth cinematic movement with a competitive high-score system to celebrate local identity through original gameplay.

---

## Design
All Game design is custom build using inkscape, please check it out here: [game design](/Assets/Design)

--
## Project Setup

Before you start, ensure you have the following installed:

* **Unity Hub**
* **Unity Editor 6000.3.2f1**
* **Git LFS** (Required for large library files)

> [⚠️!IMPORTANT]
> This project uses **Git LFS** to store large binary files. If you clone without Git LFS installed, your build files will be corrupted. Install it via `brew install git-lfs` (Mac) or `sudo apt install git-lfs` (Linux) and run `git lfs install` before cloning.

### 1. Clone the Repository

```zsh
git clone [https://github.com/your-username/ball-launcher.git](https://github.com/your-username/ball-launcher.git)
cd ball-launcher
```

### 2. .NET Environment

Unity scripts require the .NET SDK for IntelliSense. Check your version:

```zsh
dotnet --version
```

If not found, download it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

### 3. Open with Unity

1. Open **Unity Hub** and click **Add**.
2. Select the `ball-launcher` folder.
3. Click the project to open.

> [⚠️ WARNING] <br>
> If you see a "Safe Mode" warning or compilation errors regarding `UnityEngine.InputSystem`, go to **Window > Package Manager**, search for **Input System**, and click **Install**. Unity will restart to enable the new back-ends.

## 🛠 Building for iOS (Mac Users)

Generating an iOS build requires local regeneration on a Mac. Do not use build folders committed from Windows.

---
### A. Configure Build Settings

#### 1. Go to File > Build Settings and select iOS.
![file>build_setting.png](docs/img/file%3Ebuild_setting.png)


#### 2.Click Player Settings... > Other Settings.
![player_setting.png](docs/img/player_setting.png)
![other_setting.png](docs/img/other_setting.png)

3. **Target SDK Selection:**
![target_sdk.png](docs/img/target_sdk.png)

* Set to **Device SDK** for a physical iPhone.
* Set to **Simulator SDK** for the Xcode Simulator.
4. Click **Build** and choose a folder name (e.g., `Build_iOS`).
![build.png](docs/img/build.png)
