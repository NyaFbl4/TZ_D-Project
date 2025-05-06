using TZ;
using UnityEngine;
using Zenject;

namespace System
{
    public class EntryPoint : MonoBehaviour
    {
        private Player _player;

        [Inject]
        public void Construct(Player player)
        {
            _player = player;
        }
    }
}