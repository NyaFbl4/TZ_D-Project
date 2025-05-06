using Sirenix.OdinInspector;
using TZ;
using UnityEngine;
using Zenject;

namespace System
{
    public class Helper : MonoBehaviour
    {
        private Player _player;

        [Inject]
        public void Construct(Player player)
        {
            _player = player;
        }

        [Button]
        public void GetHealth(int amount)
        {
            _player.GetHealth(amount);
        }
        
        [Button]
        public void GetLives(int amount)
        {
            _player.GetLives(amount);
        }
        
        [Button]
        public void GetNewNickname(string nickname)
        {
            _player.GetNewNickname(nickname);
        }
        
        [Button]
        private void AddSkill(string newSkill)
        {
            _player.AddSkill(newSkill);
        }
        
        [Button]
        private void AddNewItem(Item newItem)
        {
            _player.AddNewItem(newItem);
        }
        
        [Button]
        public void ModifyWeapon(int value)
        {
            _player.ModifyAmmo(value);
        }
        
        [Button]
        public void ModifyRocketPack(int value)
        {
            _player.ModifyCharges(value);
        }
        
        [Button]
        public void ModifyParachute()
        {
            _player.ModifyParachute();
        }
        
        [Button]
        private void SetPlayerInfo()
        {
            Debug.Log("Health = " + _player.Health);
            Debug.Log("Lives = " + _player.Lives);
            Debug.Log("Nickname = " + _player.Nickname);
            
            foreach (var skill in _player.Skills)
            {
                Debug.Log(skill);
            }
            
            foreach (Item item in _player.Equipment.Items)
            {
                item.GetItemInfo();
            }
        }
        
        
    }
}