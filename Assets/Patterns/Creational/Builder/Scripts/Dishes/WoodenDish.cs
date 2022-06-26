using UnityEngine;

namespace Patterns.Builder
{
    public sealed class WoodenDish : Dish
    {
        [SerializeField] private Transform placePoint;

        private Product product;

        public override bool HasProduct => product;


        public override void Clean() => product.IfNotNull(product => Destroy(product.gameObject));

        public override void Place(Product product)
        {
            if (this.product)
                return;

            product.transform.SetParent(placePoint);
            product.transform.position = placePoint.position;
            this.product = product;
        }
    }
}
