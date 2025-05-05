using UnityEngine;

namespace TZ
{
    [CreateAssetMenu(menuName = "Weapon")]
    public class Weapon : Item
    {
        [SerializeField] private int _ammo;

        public Weapon(string name, int ammo) : base(name)
        {
            _ammo = ammo;
        }
    }
}