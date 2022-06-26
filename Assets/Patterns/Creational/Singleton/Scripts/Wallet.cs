using UnityEngine;

namespace Patterns.Singleton
{
    public sealed class Wallet : MonoSingleton<Wallet>
    {
        [SerializeField, Min(0)] private int amount;

        public void Add(int amount)
        {
            if (amount < 0)
                return;

            this.amount += amount;
        }

        public bool TryTake(int amount)
        {
            if (this.amount <= 0 && amount > this.amount)
                return false;

            this.amount -= amount;
            return true;
        }
    }
}
