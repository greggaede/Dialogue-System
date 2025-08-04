using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace DialogueSystem
{
    public class DialogueManager : MonoBehaviour
    {
        public static DialogueManager Instance { get; private set; }

        private DialogueData currentDialogue;
        private int currentPageIndex = 0;
        private Dictionary<string, bool> variables = new Dictionary<string, bool>();

        public UnityEvent OnDialogueUpdated;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            Instance = this;
        }

        public void LoadDialogue(DialogueData dialogueData)
        {
            currentDialogue = dialogueData;
            currentPageIndex = FindStartPageIndex();
            OnDialogueUpdated?.Invoke();
        }

        private int FindStartPageIndex()
        {
            for (int i = 0; i < currentDialogue.Pages.Count; i++)
            {
                DialoguePage page = currentDialogue.Pages[i];
                bool conditionsMet = DialogueConditions.CheckConditions(page.Conditions, variables);
                if (conditionsMet)
                {
                    return i;
                }
            }
            return 0; // fallback
        }

        public void ChooseOption(int optionIndex)
        {
            string nextPageId = currentDialogue.Pages[currentPageIndex].Options[optionIndex].NextPage;
            for (int i = 0; i < currentDialogue.Pages.Count; i++)
            {
                if (currentDialogue.Pages[i].PageID == nextPageId)
                {
                    currentPageIndex = i;
                    break;
                }
            }
            ApplyPageVariables();
            OnDialogueUpdated?.Invoke();
        }

        private void ApplyPageVariables()
        {
            List<VariableChange> vars = currentDialogue.Pages[currentPageIndex].Variables;
            foreach (VariableChange variable in vars)
            {
                variables[variable.Name] = variable.Value;
            }
        }

        public DialoguePage GetCurrentPage()
        {
            return currentDialogue.Pages[currentPageIndex];
        }
    }
}
