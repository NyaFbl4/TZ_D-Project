using Sirenix.OdinInspector;
using TZ;
using UnityEngine;
using Zenject;

namespace TZ
{
    //Класс для тестирования класса Player
    public class Helper : MonoBehaviour
    {
        private Player _player;

        [Inject]
        public void Construct(Player player)
        {
            _player = player;
        }

        //Добавление здоровья  
        [Button]
        public void AddHealth(int amount)
        {
            _player.AddHealth(amount);
        }
        
        //Добавление жизней 
        [Button]
        public void AddLives(int amount)
        {
            _player.AddLives(amount);
        }
        
        //Изменение никнейма
        [Button]
        public void GetNewNickname(string nickname)
        {
            _player.GetNewNickname(nickname);
        }
        
        //Добавление новой способности 
        [Button]
        private void AddSkill(string newSkill)
        {
            _player.AddSkill(newSkill);
        }
        
        //Добавление нового предмета 
        [Button]
        private void AddNewItem(Item newItem)
        {
            _player.AddNewItem(newItem);
        }
        
        //Модификация оружия 
        [Button]
        public void ModifyWeapon(int value)
        {
            _player.Equipment.ModifyAmmo(value);
        }
        
        //Модификация рокетпака 
        [Button]
        public void ModifyRocketPack(int value)
        {
            _player.Equipment.ModifyCharges(value);
        }
        
        //Модификация парашюта 
        [Button]
        public void ModifyParachute()
        {
            _player.Equipment.ModifyParachute();
        }
        
        //Показать всю информацию о плеере 
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