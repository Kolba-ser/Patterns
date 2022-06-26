namespace Patterns.Builder
{
    public sealed class Hamburger : Burger
    {
        public override Burger AddBun(Bun bun)
        {
            CalculateCost(bun);
            PlaceProduct(bun);
            return this;
        }
        public override Burger AddChease(Chesee chesee)
        {
            CalculateCost(chesee);
            PlaceProduct(chesee);
            return this;
        }
        public override Burger AddVegetable(Vegetable vegetable)
        {
            CalculateCost(vegetable);
            PlaceProduct(vegetable);
            return this;
        }

        public override Burger AddMeat(Meat meat)
        {
            CalculateCost(meat);
            PlaceProduct(meat);
            return this;
        }

        public override Burger AddGreen(Green green)
        {
            CalculateCost(green);
            PlaceProduct(green);
            return this;
        }
    }
}
