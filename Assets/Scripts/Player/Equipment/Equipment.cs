using System.Collections.Generic;

namespace TZ
{
    public class Equipment : IEquipment
    {
        private List<Item> _items = new();

        public List<Item> Items => _items;
        
        public void AddItem(Item item)
        {
            _items.Add(item);
        }

    }
}