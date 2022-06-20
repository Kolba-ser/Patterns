using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class MetalHeadFactory : AbstractHeadFactory
    {
        private MetalHead head;

        public MetalHeadFactory(MetalHead head)
        {
            this.head = head;
        }

        public override AbstractHead Create() => GameObject.Instantiate(head);
    }
}
