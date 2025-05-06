using UnityEngine;

namespace TZ
{
    [CreateAssetMenu(menuName = "Parachute")]
    public class Parachute : Item
    {
        public Parachute(string name) : base(name)
        {
            
        }
        
        public override void GetItemInfo()
        {
            Debug.Log("Item name " + name);
        }
    }
}