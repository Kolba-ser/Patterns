using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class MetalLegFactory : AbstractLegFactory 
    {
        private MetalLeg leg;

        public MetalLegFactory(MetalLeg leg)
        {
            this.leg = leg;
        }
        public override AbstractLeg Create() => GameObject.Instantiate(leg);
    }
}
