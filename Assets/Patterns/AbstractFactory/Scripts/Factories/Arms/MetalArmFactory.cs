using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class MetalArmFactory : AbstractArmFactory
    {

        private MetalArm arm;
        public MetalArmFactory(MetalArm arm)
        {
            this.arm = arm;
        }

        public override AbstractArm Create() => GameObject.Instantiate(arm);
    }
}
