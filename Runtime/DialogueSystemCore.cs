using UnityEngine;

namespace DialogueSystem
{
    public class DialogueSystemCore : MonoBehaviour
    {
        public static DialogueSystemCore Instance { get; private set; }
        
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            Instance = this;
        }

        public void StartDialogue(DialogueData dialogueData)
        {
            DialogueManager.Instance.LoadDialogue(dialogueData);
        }
    }
}