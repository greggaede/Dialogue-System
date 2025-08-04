using System.Collections.Generic;

namespace DialogueSystem
{
    public static class DialogueConditions
    {
        public static bool CheckConditions(List<Condition> conditions, Dictionary<string, bool> variables)
        {
            foreach (var condition in conditions)
            {
                if (!variables.ContainsKey(condition.Name) || variables[condition.Name] != condition.ExpectedValue)
                    return false;
            }
            return true;
        }
    }
}