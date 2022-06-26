using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenBodyFactory : AbstractBodyFactory
    {
        private WoodenBody body;

        public WoodenBodyFactory(WoodenBody body)
        {
            this.body = body;
        }

        public override AbstractBody Create() => GameObject.Instantiate(body);
    }
}
