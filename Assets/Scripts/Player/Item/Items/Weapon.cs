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

        public override void GetItemInfo()
        {
            Debug.Log("Item name " + name + ", Ammo " + _ammo);
        }

        public virtual void Modify(int value)
        {
            _ammo = value;
            Debug.Log("New ammo = " + _ammo);
        }
    }
}