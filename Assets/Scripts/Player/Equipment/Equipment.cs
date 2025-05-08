using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace TZ
{
    public class Equipment : IEquipment
    {
        private List<Item> _items = new();
        
        private Weapon _weapon;
        private RocketPack _rocketPack;
        private Parachute _parachute;

        public List<Item> Items => _items;

        public void AddItem(Item newItem)
        {
            _items.Add(newItem);

            switch (newItem)
            {
                case Weapon weapon:
                    _weapon = weapon;
                    break;
                
                case RocketPack rocketPack:
                    _rocketPack = rocketPack;
                    break;
                
                case Parachute parachute:
                    _parachute = parachute;
                    break;
            }
        }

        //Метод для модификации оружия
        public void ModifyAmmo(int value)
        {
            if (_weapon != null)
            {
                _weapon.Modify(value);
                
                UnityEngine.Debug.Log("New ammo = " + _weapon.Ammo);
            }
            else
            {
                UnityEngine.Debug.Log("No Weapon");
            }
        }
        
        //Метод для модификации рокетпака
        public void ModifyCharges(int value)
        {
            if (_rocketPack != null)
            {
                _rocketPack.Modify(value);
                
                UnityEngine.Debug.Log("New ammo = " + _rocketPack.Charges);
            }
            else
            {
                UnityEngine.Debug.Log("No RocketPack");
            }
        }

        //Метод для модификации парашюта 
        public void ModifyParachute()
        {
            if (_rocketPack != null)
            {
                UnityEngine.Debug.Log("Not modify");
            }
            else
            {
                UnityEngine.Debug.Log("No Parachute");
            }
        }
    }
}