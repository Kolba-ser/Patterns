using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite
{
    public sealed class Bootstraper : MonoBehaviour
    {
        [SerializeField] private CameraRaycaster cameraRaycaster;
        [Space(20)]
        [SerializeField] private int amount;
        [SerializeField] private float duration;
        [SerializeField] private EntityType type;
        private enum EntityType
        {
            Squad,
            Single
        }

        private void Awake()
        {

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

            new EntityMover(cameraRaycaster, entity, duration);
        }

        private Squad CreateSquad()
        {
            List<IMovableEntity> units = new List<IMovableEntity>(amount);
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
