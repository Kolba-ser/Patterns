

using UnityEngine;

namespace Patterns.FactoryMethod
{
    public sealed class MetalStack : Stack
    {
        [SerializeField] private MetalCreator creator;

        protected override void Create()
        {
            float currentHeight = 0;
            for (int i = 0; i < Tiers; i++)
            {
                if (creator.TryCreate(out Product product))
                {
                    currentHeight += product.GetSize().y;
                    product.transform.position = new Vector3(transform.position.x,
                                                    transform.position.y + currentHeight,
                                                    transform.position.z);
                    product.transform.SetParent(transform);
                }
                else
                {
                    Debug.Log($"Run out of money in the {GetType()}");
                    return;
                }
            }
        }
    }
}
