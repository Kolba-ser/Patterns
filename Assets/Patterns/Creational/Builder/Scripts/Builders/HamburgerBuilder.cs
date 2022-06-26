using System;
using UnityEngine;

namespace Patterns.Builder
{
    public sealed class HamburgerBuilder : BurgerBuilder<Hamburger>
    {
        private Meat beef;
        private Chesee chadder;
        private Green salad;
        private Vegetable tomato;
        private Vegetable onion;
        private Bun bottomBun;
        private Bun topBun;

        public HamburgerBuilder(Meat beef, Chesee chadder, Green salad, Vegetable tomato, Vegetable onion, Bun bottomBun, Bun topBun)
        {
            this.beef = beef;
            this.chadder = chadder;
            this.salad = salad;
            this.tomato = tomato;
            this.onion = onion;
            this.bottomBun = bottomBun;
            this.topBun = topBun;
        }

        public override Hamburger Build()
        {
            var go = new GameObject() { name = "Hamburger" };
            var hamburger = go.AddComponent<Hamburger>();
            hamburger.AddBun(GameObject.Instantiate(bottomBun))
                .AddMeat(GameObject.Instantiate(beef))
                .AddChease(GameObject.Instantiate(chadder))
                .AddGreen(GameObject.Instantiate(salad))
                .AddVegetable(GameObject.Instantiate(tomato))
                .AddVegetable(GameObject.Instantiate(onion))
                .AddBun(GameObject.Instantiate(topBun));

            return hamburger;
        }
    }
}
