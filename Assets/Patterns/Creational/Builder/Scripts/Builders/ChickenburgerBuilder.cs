using System;
using UnityEngine;

namespace Patterns.Builder
{
    public sealed class ChickenburgerBuilder : BurgerBuilder<Chickenburger>
    {
        private Meat chicken;
        private Green salad;
        private Bun topBun;
        private Bun bottomBun;

        public ChickenburgerBuilder( TopBun topBun, BottomBun bottomBun, Chicken chicken, Green salad)
        {
            this.topBun = topBun;
            this.bottomBun = bottomBun;
            this.chicken = chicken;
            this.salad = salad;
        }

        public override Chickenburger Build()
        {
            var go = new GameObject() { name = "Chickenburger" };
            var chickenburger = go.AddComponent<Chickenburger>();
            chickenburger.AddBun(GameObject.Instantiate(bottomBun))
                            .AddMeat(GameObject.Instantiate(chicken))
                            .AddGreen(GameObject.Instantiate(salad))
                            .AddGreen(GameObject.Instantiate(salad))
                            .AddBun(GameObject.Instantiate(topBun));

            return chickenburger;
        }

    }
}
