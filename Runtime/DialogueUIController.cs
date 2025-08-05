using UnityEngine;
using UnityEngine.UIElements;

namespace DialogueSystem
{
    public class DialogueUIController : MonoBehaviour
    {
        private Label dialogueText;
        private Label speakerName;
        private VisualElement avatarContainer;
        private VisualElement optionsContainer;

        private DialogueManager dialogueManager;
        private VisualTreeAsset optionButtonTemplate;

        private void OnEnable()
        {
            UIDocument uiDocument = GetComponent<UIDocument>();
            VisualElement root = uiDocument.rootVisualElement;

            dialogueText = root.Q<Label>("DialogueText");
            speakerName = root.Q<Label>("SpeakerName");
            avatarContainer = root.Q<VisualElement>("AvatarContainer");
            optionsContainer = root.Q<VisualElement>("OptionsContainer");

            dialogueManager = DialogueManager.Instance;
            dialogueManager.OnDialogueUpdated.AddListener(UpdateDialogueUI);
            UpdateDialogueUI();
        }

        private void UpdateDialogueUI()
        {
            DialoguePage currentPage = dialogueManager.GetCurrentPage();
            if (currentPage.Lines.Count > 0)
            {
                DialogueLine currentLine = currentPage.Lines[0]; // Simplified
                dialogueText.text = currentLine.Text;
                speakerName.text = currentLine.Speaker;
                // Avatar image handling can be added here later
            }

            optionsContainer.Clear();
            for (int i = 0; i < currentPage.Options.Count; i++)
            {
                PlayerOption option = currentPage.Options[i];
                Button optionButton = new Button(() => dialogueManager.ChooseOption(i))
                {
                    text = option.OptionText
                };
                optionButton.AddToClassList("button-option");
                optionsContainer.Add(optionButton);
            }
        }
    }
}