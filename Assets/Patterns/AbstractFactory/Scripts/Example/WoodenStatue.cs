using UnityEngine;

namespace Patterns.AbstractFactory
{
    public sealed class WoodenStatue : Statue
    {
        [SerializeField] private WoodenArm woodenArm;
        [SerializeField] private WoodenBody woodenBody;
        [SerializeField] private WoodenLeg woodenLeg;
        [SerializeField] private WoodenHead woodenHead;

        private WoodenCharacterFactory characterFactory;
        private void Awake()
        {
            characterFactory = new WoodenCharacterFactory(woodenArm, woodenBody, woodenHead, woodenLeg);
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
