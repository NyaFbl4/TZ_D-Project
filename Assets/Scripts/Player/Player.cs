using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
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
        public IEquipment Equipment => _equipment;

        public static void Initialize(int health, int lives, string nickname, List<string> skills)
        {
            if (_instance == null)
            {
                _instance = new Player(health, lives, nickname, skills);
            }
        }
        
        private Player(int health, int lives, string nickname, List<string> skills)
        {
            _health = health;
            _lives = lives;
            _nickname = nickname;
            _skills = skills;
            _equipment = new Equipment();
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

        public void SetPlayerInfo()
        {
            Debug.Log("Health = " + _health);
            Debug.Log("Lives = " + _lives);
            Debug.Log("Nickname = " + _nickname);
            
            foreach (var skill in _skills)
            {
                Debug.Log(skill);
            }
            
            foreach (var item in _equipment.Items)
            {
                Debug.Log(item.Name);
            }
        }
    }
}
