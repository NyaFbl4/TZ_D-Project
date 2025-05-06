using System;
using System.Collections.Generic;

namespace TZ
{
    public interface IPlayer
    {
        // Методы изменения состояния
        public void GetHealth(int amount);
        public void GetLives(int amount);
        public void GetNewNickname(string nickname);
        public void AddNewItem(Item newItem);
        public void ModifyAmmo(int value);
        public void ModifyCharges(int value);
        public void ModifyParachute();
    }
}