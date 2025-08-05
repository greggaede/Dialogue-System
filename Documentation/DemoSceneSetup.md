# Demo Scene Setup Instructions

1. Create a new Unity Scene named 'DialogueDemoScene'.
2. Add a Canvas with the following UI elements:
   - Text (Dialogue Text) -> Assign to DialogueUIController.dialogueText
   - Image (Avatar) -> Assign to DialogueUIController.avatarImage
   - Text (Speaker Name) -> Assign to DialogueUIController.speakerNameText
   - Vertical Layout Group (Options Container) -> Assign to DialogueUIController.optionsContainer
   - Button Prefab (for options) -> Assign to DialogueUIController.optionButtonPrefab

3. Create an empty GameObject named 'DialogueSystem' and attach the following components:
   - DialogueSystemCore
   - DialogueManager
   - DialogueUIController

4. Prepare a sample JSON file under Resources and load it via DialogueSystemCore on Start.

5. Play the scene and test selecting dialogue options.