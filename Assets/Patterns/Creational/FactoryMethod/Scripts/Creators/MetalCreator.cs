using Patterns.Singleton;
using UnityEngine;

namespace Patterns.FactoryMethod
{
    public sealed class MetalCreator : Creator
    {
        [SerializeField] private Metal product;


        public override bool TryCreate(out Product metal)
        {
            metal = null;

            if (Wallet.Instance.TryTake(product.Price))
            {
                metal = Instantiate(product);
            }

            return metal;
        }
    }
}
