using UnityEngine;

namespace Patterns.Builder
{
    public abstract class Dish : MonoBehaviour
    {
        public abstract bool HasProduct { get; }

        public abstract void Place(Product product);

        public abstract void Clean();
    }
}
