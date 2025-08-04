# Dialogue System for Unity

A flexible, JSON-driven dialogue system for Unity, designed for quick integration and easy content editing.
Ideal for branching dialogue trees, NPC conversations, and narrative games.

---

## 🌟 Features
- JSON-based dialogue storage (writer-friendly & localization-ready)
- Unity Editor Window for dialogue crafting & JSON generation
- Typewriter text effect with NPC avatars and player choice options
- Supports branching dialogues with condition-based flow control
- Modular & lightweight — easily extendable via UnityEvents
- Demo Scene included for quick setup reference

---

## 📂 Project Structure
```
DialogueSystem/
├── Runtime/
│ ├── DialogueSystemCore.cs
│ ├── DialogueData.cs
│ ├── DialogueManager.cs
│ ├── DialogueUIController.cs
│ └── Utilities/
│ └── JSONParser.cs
├── Editor/
│ ├── DialogueEditorWindow.cs
│ ├── DialogueJSONGenerator.cs
│ └── EditorUtilities/
├── Samples/
│ ├── Scenes/
│ │ └── DialogueDemoScene.unity
│ ├── JSON/
│ │ └── SampleDialogue.json
│ └── Sprites/
│ └── NPC_Example_Avatar.png
├── Documentation/
│ ├── README.md
│ ├── QuickStart.md
│ └── API.md
├── Tests/
│ └── DialogueSystemTests.cs
├── LICENSE
└── DialogueSystem.asmdef
```


---

## 🚀 Quick Start
1. Clone this repository or add it as a local package in Unity.
2. Open the `Samples/Scenes/DialogueDemoScene.unity` scene.
3. Run the scene to see the dialogue system in action.
4. Modify or create new dialogues via the Dialogue Editor Window.
5. Link your dialogues via JSON files into any scene.

---

## 🧱 How It Works
| Component | Responsibility |
|-----------|----------------|
| **DialogueManager.cs** | Core runtime logic handling dialogue flow. |
| **DialogueUIController.cs** | UI component for rendering text, avatars, and options. |
| **DialogueEditorWindow.cs** | Unity Editor tool to craft dialogue JSON visually. |
| **JSONParser.cs** | Handles loading/saving JSON data. |
| **DialogueData.cs** | Data models for dialogue structure (nodes, conditions, variables). |

---

## 📝 Roadmap
- [ ] Decouple game-specific logic into extensible API/Events.
- [ ] Add localization support.
- [ ] Optional: Visual Node Graph Editor.
- [ ] Customizable UI Skinning.
- [ ] Full Documentation & Tutorials.

---

## 💬 License
MIT License — Free to use, modify, and distribute.

---

## ✨ Credits
Developed by [Greg Gaede](https://github.com/greggaede) with assistance from ChatGPT.
