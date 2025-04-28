using System;
using System.Collections.Generic;
using System.Text;

namespace PGL.Core
{
    public class Slot
    {
        public string Name { get; private set; }
        public string Value { get; private set; }

        public Slot()
        {
            Name = string.Empty;
            Value = string.Empty;
        }
        public Slot(string name)
        {
            Name = name;
            Value = string.Empty;
        }
        public Slot(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        public override string ToString()
        {
            return $"Slot(Name: {Name}, Value: {Value})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Slot otherSlot)
            {
                return Name == otherSlot.Name && Value == otherSlot.Value;
            }
            return false; 
        }
        public override int GetHashCode()
        {
            return (Name, Value).GetHashCode();
        }
    }
}