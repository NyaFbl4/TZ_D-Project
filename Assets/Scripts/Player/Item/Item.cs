using UnityEngine;

namespace TZ
{
    public class Item : ScriptableObject
    {
        [SerializeField] protected string name;

        public string Name => name;

        protected Item(string name)
        {
            this.name = name;
        }
        
        //Виртуальный метод для получения информации о предмете
        public virtual void GetItemInfo()
        { }
        
        //Виртуальный метод для модификации предмета
        public virtual void Modify(int value)
        { }
    }
}