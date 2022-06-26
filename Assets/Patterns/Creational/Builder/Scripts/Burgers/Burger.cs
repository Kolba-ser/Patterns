using UnityEngine;
using UnityEngine.Assertions;

namespace Patterns.Builder
{
    public class Burger : Product
    {
        public new float Height { get; private set;}
        public virtual Burger AddChease(Chesee chesee) => this;
        public virtual Burger AddGreen(Green green) => this;
        public virtual Burger AddMeat(Meat meat) => this;
        public virtual Burger AddVegetable(Vegetable vegetable) => this;
        public virtual Burger AddBun(Bun bun) => this;

        protected void CalculateCost(Product product)
        {
            Assert.IsFalse(product.Cost < 0, $"The cost of {product.Name} is less than zero");
            cost += product.Cost;
        } 

        protected void PlaceProduct(Product product)
        {
            Vector3 placePosition = new Vector3(
                transform.position.x,
                transform.position.y + Height + product.Height / 2,
                transform.position.z);
            Height += product.Height;

            product.transform.SetParent(transform);
            product.transform.position = placePosition;
        }


    }
}
