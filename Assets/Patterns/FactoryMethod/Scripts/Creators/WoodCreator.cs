using Patterns.Singleton;
using UnityEngine;

namespace Patterns.FactoryMethod
{
    public sealed class WoodCreator : Creator
    {
        [SerializeField] private Wood product;

        public override bool TryCreate(out Product wood)
        {
            wood = null;
            if (Wallet.Instance.TryTake(product.Price))
            {
                wood = Instantiate(product);
            }

            return wood;
        }
    }
}
