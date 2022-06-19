using UnityEngine;

namespace Patterns.FactoryMethod
{
    public abstract class Stack : MonoBehaviour
    {
        [SerializeField, Min(0)] private int tiers;

        public int Tiers => tiers;

        protected abstract void Create();

        private void Start()
        {
            Create();
        }
    }
}
