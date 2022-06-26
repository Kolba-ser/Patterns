using UnityEngine;

namespace Patterns.AbstractFactory
{
    public abstract class AbstractBody : MonoBehaviour
    {
        [Header("Head")]
        [SerializeField] protected Transform headPoint;
        [Header("Arms")]
        [SerializeField] protected Transform leftArmPoint;
        [SerializeField] protected Transform rightArmPoint;
        [Header("Legs")]
        [SerializeField] protected Transform leftLegPoint;
        [SerializeField] protected Transform rigthLegPoint;

        protected AbstractHead head;

        protected AbstractBody body;

        protected AbstractArm leftArm;
        protected AbstractArm rightArm;

        protected AbstractLeg leftLeg;
        protected AbstractLeg rightLeg;

        public abstract void AttachHead(AbstractHead head);

        public abstract void AttachLegs(AbstractLeg leftLeg, AbstractLeg rightLeg);

        public abstract void AttachArms(AbstractArm leftArm, AbstractArm rightArm);

    }
}
