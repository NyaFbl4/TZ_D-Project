using UnityEngine;

namespace TZ
{
    public class Item : ScriptableObject
    {
        [SerializeField] protected string name;

        public string Name => name;

        public Item(string name)
        {
            this.name = name;
        }

        public virtual void GetItemInfo()
        { }
        
        public virtual void Modify(int value)
        { }
    }
}