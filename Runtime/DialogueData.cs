using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    [System.Serializable]
    public class DialogueData
    {
        public string Title;
        public List<DialoguePage> Pages;
    }

    [System.Serializable]
    public class DialoguePage
    {
        public string PageID;
        public List<Condition> Conditions;
        public List<DialogueLine> Lines;
        public List<PlayerOption> Options;
        public List<VariableChange> Variables;
    }

    [System.Serializable]
    public class DialogueLine
    {
        public string Speaker;
        public string Avatar;
        public string Text;
    }

    [System.Serializable]
    public class PlayerOption
    {
        public string OptionText;
        public string NextPage;
    }

    [System.Serializable]
    public class Condition
    {
        public string Name;
        public bool ExpectedValue;
    }

    [System.Serializable]
    public class VariableChange
    {
        public string Name;
        public bool Value;
    }
}