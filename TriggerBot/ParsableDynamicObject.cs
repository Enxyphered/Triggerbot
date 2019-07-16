using System.Collections.Generic;

namespace Cinnamine
{
    public abstract class ParsableDynamicObject
    {
        public Dictionary<string, dynamic> Dictionary = new Dictionary<string, dynamic>();
        public abstract void Parse();
        public dynamic this[string propertyName] { get => Dictionary[propertyName]; set => Dictionary[propertyName] = value; }
        public bool ContainsKey(string key) => Dictionary.ContainsKey(key);
    }
}
