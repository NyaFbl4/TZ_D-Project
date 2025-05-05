using TZ;
using UnityEngine;

namespace System
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private PlayerStats _playerStats;
        
        private void Start()
        {
            Player.Initialize(_playerStats.Health, _playerStats.Lives, _playerStats.Nickname, _playerStats.Skills);
        }
    }
}