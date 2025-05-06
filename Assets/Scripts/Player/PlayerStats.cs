using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    [CreateAssetMenu(menuName = "Player Stats")]
    public class PlayerStats : ScriptableObject
    {
        [SerializeField] private int _health;
        [SerializeField] private int _lives;
        [SerializeField] private string _nickname;
        [SerializeField] private List<string> _skills;

        public int Health => _health;
        public int Lives => _lives;
        public string Nickname => _nickname;
        public List<string> Skills => _skills;
    }
}