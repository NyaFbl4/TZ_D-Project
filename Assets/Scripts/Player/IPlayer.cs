using System;
using System.Collections.Generic;

namespace TZ
{
    public interface IPlayer
    {
        // Методы изменения состояния
        public void AddHealth(int amount);
        public void AddLives(int amount);
        public void GetNewNickname(string nickname);
        public void AddNewItem(Item newItem);
    }
}