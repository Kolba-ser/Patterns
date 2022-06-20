using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class MetalBodyFactory : AbstractBodyFactory
    {
        private MetalBody body;

        public MetalBodyFactory(MetalBody body)
        {
            this.body = body;
        }

        public override AbstractBody Create() => GameObject.Instantiate(body);
    }
}
