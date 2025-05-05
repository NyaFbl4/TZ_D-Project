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
    }
}