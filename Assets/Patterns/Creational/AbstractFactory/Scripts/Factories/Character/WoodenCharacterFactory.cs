using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenCharacterFactory : AbstractCharacterFactory
    {
        private WoodenArmFactory armFactory;
        private WoodenBodyFactory bodyFactory;
        private WoodenHeadFactory headFactory;
        private WoodenLegFactory legFactory;

        public WoodenCharacterFactory(WoodenArm arm, WoodenBody body, WoodenHead head, WoodenLeg leg)
        {
            legFactory = new WoodenLegFactory(leg);
            armFactory = new WoodenArmFactory(arm);
            bodyFactory = new WoodenBodyFactory(body);
            headFactory = new WoodenHeadFactory(head);
        }

        public override GameObject Create()
        {
            var body = bodyFactory.Create();
            var head = headFactory.Create();

            var leftArm = armFactory.Create();
            var rightArm = armFactory.Create();

            var leftLeg = legFactory.Create();
            var rightLeg = legFactory.Create();

            var character = new GameObject();
            character.name = "Wooden Bob";

            body.AttachHead(head);
            body.AttachArms(leftArm, rightArm);
            body.AttachLegs(leftLeg, rightLeg);

            body.transform.SetParent(character.transform);

            return character;
        }
    }
}
