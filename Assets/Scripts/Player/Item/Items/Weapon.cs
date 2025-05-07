using UnityEngine;

namespace TZ
{
    [CreateAssetMenu(menuName = "Weapon")]
    public class Weapon : Item
    {
        [SerializeField] private int _ammo;

        public int Ammo => _ammo;

        public Weapon(string name, int ammo) : base(name)
        {
            _ammo = ammo;
        }

        //Метод для получения информации о предмете
        public override void GetItemInfo()
        {
            Debug.Log("Item name " + name + ", Ammo " + _ammo);
        }

        //Метод для модификации предмета
        public virtual void Modify(int value)
        {
            _ammo = value;
            Debug.Log("New ammo = " + _ammo);
        }
    }
}