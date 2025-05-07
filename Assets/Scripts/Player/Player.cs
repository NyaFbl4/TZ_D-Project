using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Debug = UnityEngine.Debug;

namespace TZ
{
    [Serializable]
    public class Player : IPlayer
    {
        private static Player _instance;

        private int _health;
        private int _lives;
        private string _nickname;
        private List<string> _skills;
        private Equipment _equipment;

        public int Health => _health;
        public int Lives => _lives;
        public string Nickname => _nickname;
        public List<string> Skills => _skills;
        public Equipment Equipment => _equipment;

        public Player(int health, int lives, string nickname, List<string> skills, Equipment equipment)
        {
            _health = health;
            _lives = lives;
            _nickname = nickname;
            _skills = skills;
            _equipment = equipment;

            Debug.Log("Player created");
        }
        
        //Добавление здоровья
        public void AddHealth(int amount)
        {
            _health += amount;
            
            Debug.Log("New Health = " + _health);
        }
        
        //Добавление жизней
        public void AddLives(int amount)
        {
            _lives += amount;
            
            Debug.Log("New Lives = " + _lives);
        }

        //Изменение никнейма
        public void GetNewNickname(string nickname)
        {
            _nickname = nickname;
            
            Debug.Log("New Nickname = " + _nickname);
        }

        //Добавление новой способности
        public void AddSkill(string newSkill)
        {
            _skills.Add(newSkill);

            Debug.Log("New Skill = " + newSkill);
        }

        //Добавление нового предмета
        public void AddNewItem(Item newItem)
        {
            _equipment.AddItem(newItem);

            Debug.Log("New item " + newItem.Name);
        }
    }
}
