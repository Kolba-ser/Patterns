using UnityEngine;

namespace Patterns.FactoryMethod
{
    public abstract class Stack : MonoBehaviour
    {
        [SerializeField, Min(0)] private int tiers;

        protected float height;

        public float Height => height;
        public int Tiers => tiers;

        protected abstract void Create();

        private void Start()
        {
            Create();
        }
    }
}
