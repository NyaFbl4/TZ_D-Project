using UnityEngine;

namespace TZ
{
    [CreateAssetMenu(menuName = "RocketPack")]
    public class RocketPack : Item
    {
         [SerializeField] private int _charges;

         public RocketPack(string name, int charges) : base(name)
         {
             _charges = charges;
         }

         public override void GetItemInfo()
         {
             Debug.Log("Item name " + name + ", Charges " + _charges);
         }
         
         public virtual void Modify(int value)
         {
             _charges = value;
             Debug.Log("New charges = " + _charges);
         }
    }
}