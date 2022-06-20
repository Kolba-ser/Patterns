using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class MetalStatue : Statue
    {
        [SerializeField] private MetalArm MetalArm;
        [SerializeField] private MetalBody MetalBody;
        [SerializeField] private MetalLeg MetalLeg;
        [SerializeField] private MetalHead MetalHead;

        private MetalCharacterFactory characterFactory;
        private void Awake()
        {
            characterFactory = new MetalCharacterFactory(MetalArm, MetalBody, MetalHead, MetalLeg);
        }

        protected override void Build()
        {
            var character = characterFactory.Create();
            character.transform.SetParent(transform);
            character.transform.position = transform.position;
            character.transform.rotation = transform.rotation;
        }
    }
}
