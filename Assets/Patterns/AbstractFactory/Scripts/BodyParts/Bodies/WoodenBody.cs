using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenBody : AbstractBody
    {
        public override void AttachHead(AbstractHead head)
        {
            this.head = head;
            head.transform.position = headPoint.position;
            head.transform.rotation = headPoint.rotation;

            head.transform.SetParent(transform);
        }
        public override void AttachLegs(AbstractLeg leftLeg, AbstractLeg rightLeg)
        {
            this.leftLeg = leftLeg;
            this.rightLeg = rightLeg;

            leftLeg.transform.position = leftLegPoint.position;
            leftLeg.transform.rotation = leftLegPoint.rotation;
            leftLeg.transform.SetParent(leftLegPoint);

            rightLeg.transform.rotation = rigthLegPoint.rotation;
            rightLeg.transform.rotation = rigthLegPoint.rotation;
            rightLeg.transform.SetParent(rigthLegPoint);

            var legs = new GameObject() { name = "Legs" };
            rigthLegPoint.transform.SetParent(legs.transform);
            leftLegPoint.transform.SetParent(legs.transform);
            legs.transform.SetParent(transform);
        }
        public override void AttachArms(AbstractArm leftArm, AbstractArm rightArm)
        {
            this.leftArm = leftArm;
            this.rightArm = rightArm;

            leftArm.transform.position = leftArmPoint.position;
            leftArm.transform.rotation = leftArmPoint.rotation;
            leftArm.transform.SetParent(leftArmPoint);

            rightArm.transform.position = rightArmPoint.position;
            rightArm.transform.rotation = rightArmPoint.rotation;
            rightArm.transform.SetParent(rightArmPoint);

            var arms = new GameObject() { name = "Arms" };
            leftArmPoint.transform.SetParent(arms.transform);
            rightArmPoint.transform.SetParent(arms.transform);
            arms.transform.SetParent(transform);
        }
    }
}
