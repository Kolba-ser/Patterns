using UnityEngine;

namespace Patterns.FactoryMethod
{
    public abstract class Product : MonoBehaviour
    {
        [SerializeField] private MeshRenderer renderer;
        [SerializeField, Min(0)] private int price;

        private Vector3 hight;

        public int Price => price;

        public Vector3 GetSize()
        {
            if (hight == default)
            {
                hight = renderer.bounds.size;
            }

            return hight;
        }
    }
}
