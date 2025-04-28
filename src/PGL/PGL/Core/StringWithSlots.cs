using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PGL.Core
{
    public class StringWithSlots
    {
        public List<Slot> Slots { get; private set; }
        public string Pattern { get; private set; }

        private string slotPattern = @"\{(.*?)\}";

        public StringWithSlots()
        {
            Slots = new List<Slot>();
            Pattern = string.Empty;
        }
        public StringWithSlots(string pattern)
        {
            Slots = new List<Slot>();
            Pattern = pattern;
            FindSlots();
        }
        public string GetFormattedString()
        {
            string formattedString = Pattern;

            foreach (var slot in Slots)
            {
                // Заменяем {Name} на значение слота
                formattedString = formattedString.Replace($"{{{slot.Name}}}", slot.Value);
            }

            return formattedString;
        }
        private void FindSlots()
        {
            List<string> slotNames = new List<string>();

            MatchCollection matches = Regex.Matches(Pattern, slotPattern);
            foreach (Match match in matches)
            {
                Slots.Add(new Slot(match.Groups[1].Value));
            }
        }
    }
}
