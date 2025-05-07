using UnityEngine;

namespace TZ
{
    [CreateAssetMenu(menuName = "Parachute")]
    public class Parachute : Item
    {
        public Parachute(string name) : base(name)
        {
            
        }
        
        //Метод для получения информации о предмете
        public override void GetItemInfo()
        {
            Debug.Log("Item name " + name);
        }
    }
}