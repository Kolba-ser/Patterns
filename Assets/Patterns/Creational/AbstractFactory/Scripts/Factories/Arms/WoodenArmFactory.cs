using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenArmFactory : AbstractArmFactory
    {

        private WoodenArm arm;
        public WoodenArmFactory(WoodenArm arm)
        {
            this.arm = arm;
        }

        public override AbstractArm Create() => GameObject.Instantiate(arm);

    }
}
