using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenHeadFactory : AbstractHeadFactory
    {
        private WoodenHead head;

        public WoodenHeadFactory(WoodenHead head)
        {
            this.head = head;
        }

        public override AbstractHead Create() => GameObject.Instantiate(head);
    }
}
