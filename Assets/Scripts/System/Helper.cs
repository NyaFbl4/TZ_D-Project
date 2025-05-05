using Sirenix.OdinInspector;
using TZ;
using UnityEngine;

namespace System
{
    public class Helper : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Item _newItem;

        [Button]
        private void TakePlayer()
        {
            Player.Instance.AddNewItem(_newItem);
        }
        
    }
}