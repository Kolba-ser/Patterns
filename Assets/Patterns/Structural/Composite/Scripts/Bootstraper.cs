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

        private void Awake()
        {
            List<IMovableEntity> units = new List<IMovableEntity>(amount);
            for (int i = 0; i < amount; i++)
            {
                var created = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                var unit = created.AddComponent<Unit>();
                created.transform.position = Vector3.zero;

                units.Add(unit);
            }

            Squad squad = new Squad(units);
            new SquadMover(cameraRaycaster, squad, duration);
        }
    }
}
