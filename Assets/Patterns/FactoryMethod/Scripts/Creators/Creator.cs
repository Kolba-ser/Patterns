using UnityEngine;

namespace Patterns.FactoryMethod
{
    public abstract class Creator : MonoBehaviour
    {
        public abstract bool TryCreate (out Product product);
    }
}
