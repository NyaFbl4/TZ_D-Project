using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
        private Weapon _weapon;
        private RocketPack _rocketPack;
        private Parachute _parachute;

        public int Health => _health;
        public int Lives => _lives;
        public string Nickname => _nickname;
        public List<string> Skills => _skills;
        public Equipment Equipment => _equipment;

        public Weapon Weapon => _weapon;
        public RocketPack RocketPack => _rocketPack;
        public Parachute Parachute => _parachute;

        public static void Initialize(int health, int lives, string nickname, List<string> skills)
        {
            if (_instance == null)
            {
                //_instance = new Player(health, lives, nickname, skills);
            }
        }
        
        public Player(int health, int lives, string nickname, List<string> skills, Equipment equipment)
        {
            _health = health;
            _lives = lives;
            _nickname = nickname;
            _skills = skills;
            _equipment = equipment;

            Debug.Log("Player created");
        }

        public static IPlayer Instance => 
            _instance ?? throw new System.InvalidOperationException
                ("Player not initialized. Call Player.Initialize() first.");
        
        public void GetHealth(int amount)
        {
            _health += amount;
            
            Debug.Log("New Health = " + _health);
        }

        public void GetLives(int amount)
        {
            _lives += amount;
            
            Debug.Log("New Lives = " + _lives);
        }

        public void GetNewNickname(string nickname)
        {
            _nickname = nickname;
            
            Debug.Log("New Nickname = " + _nickname);
        }

        public void AddSkill(string newSkill)
        {
            _skills.Add(newSkill);
            
            Debug.Log("New Skill = " + newSkill);
        }

        public void AddNewItem(Item newItem)
        {
            _equipment.AddItem(newItem);

            foreach (var item in _equipment.Items)
            {
                Debug.Log(item.Name);
            }
        }

        public void ModifyAmmo(int value)
        {
            if (_weapon != null)
            {
                _weapon.Modify(value);
            }
            else
            {
                Debug.Log("No Weapon");
            }
        }
        
        public void ModifyCharges(int value)
        {
            if (_rocketPack != null)
            {
                _rocketPack.Modify(value);
            }
            else
            {
                Debug.Log("No RocketPack");
            }
        }

        public void ModifyParachute()
        {
            if (_rocketPack != null)
            {
                Debug.Log("No modify");
            }
            else
            {
                Debug.Log("No RocketPack");
            }
        }
    }
}
