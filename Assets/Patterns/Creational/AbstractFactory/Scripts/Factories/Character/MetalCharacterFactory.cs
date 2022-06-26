using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class MetalCharacterFactory : AbstractCharacterFactory
    {

        private MetalArmFactory armFactory;
        private MetalBodyFactory bodyFactory;
        private MetalHeadFactory headFactory;
        private MetalLegFactory legFactory;

        public MetalCharacterFactory(MetalArm arm, MetalBody body, MetalHead head, MetalLeg leg)
        {
            legFactory = new MetalLegFactory(leg);
            armFactory = new MetalArmFactory(arm);
            bodyFactory = new MetalBodyFactory(body);
            headFactory = new MetalHeadFactory(head);
        }

        public override GameObject Create()
        {
            var body = bodyFactory.Create();
            var head = headFactory.Create();

            var leftArm = armFactory.Create();
            var rightArm = armFactory.Create();

            var leftLeg = legFactory.Create();
            var rightLeg = legFactory.Create();

            var character = new GameObject(){ name = "Metal Bob" };

            body.AttachHead(head);
            body.AttachArms(leftArm, rightArm);
            body.AttachLegs(leftLeg, rightLeg);

            body.transform.SetParent(character.transform);

            return character;
        }
    }
}
