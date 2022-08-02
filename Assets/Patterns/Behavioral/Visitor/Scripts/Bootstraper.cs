using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public sealed class Bootstraper : MonoBehaviour
    {
        [SerializeField] private CameraRaycaster cameraRaycaster;
        [Space(20)]
        [SerializeField] private EntityType type;
        [Space(20)]
        [SerializeField] private int amount;
        [SerializeField] private float duration;
        [Space(20)]
        [SerializeField] private Material squadMaterial;
        [SerializeField] private Material unitMaterial;

        private IMovableEntityVisitor painter;

        private enum EntityType
        {
            Squad,
            Single
        }

        private void Awake()
        {
            painter = new EntityPainter(squadMaterial, unitMaterial);
            IMovableEntity entity = null;
            switch (type)
            {
                case EntityType.Squad:
                    entity = CreateSquad();
                    break;
                case EntityType.Single:
                    entity = CreateUnit();
                    break;
            }
            entity.Accept(painter);
            new EntityMover(cameraRaycaster, entity, duration);
        }

        private Squad CreateSquad()
        {
            List<Unit> units = new List<Unit>(amount);
            for (int i = 0; i < amount; i++)
            {
                var created = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                var unit = created.AddComponent<Unit>();
                created.transform.position = Vector3.zero;

                units.Add(unit);
            }
            return new Squad(units);
        }
        private Unit CreateUnit()
        {
            var created = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            var unit = created.AddComponent<Unit>();
            created.transform.position = Vector3.zero;
            return unit;
        }
    }
}
