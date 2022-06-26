using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenLegFactory : AbstractLegFactory
    {
        private WoodenLeg leg;

        public WoodenLegFactory(WoodenLeg leg)
        {
            this.leg = leg;
        }
        public override AbstractLeg Create() => GameObject.Instantiate(leg);
    }
}
