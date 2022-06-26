using UnityEngine;

namespace Patterns.FactoryMethod.Scripts
{
    public sealed class WoodenStack : Stack
    {
        [SerializeField] private WoodCreator creator;

        protected override void Create()
        {
            for (int i = 0; i < Tiers; i++)
            {
                if (creator.TryCreate(out Product product))
                {
                    product.transform.position = new Vector3(transform.position.x,
                                                    transform.position.y + height + product.GetSize().y / 2,
                                                    transform.position.z);
                    height += product.GetSize().y;
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
