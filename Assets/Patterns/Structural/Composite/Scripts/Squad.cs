using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite
{
    public sealed class Squad : IMovableEntity
    {
        private List<IMovableEntity> unitsInSquad;

        private readonly float offset = 1f;

        public Squad(List<IMovableEntity> units)
        {
            this.unitsInSquad = units;
        }

        public void MoveTo(Vector3 destination, float duration)
        {
            int x = unitsInSquad.Count / 2;
            int z = unitsInSquad.Count / x;

            int unitIndex = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    unitsInSquad[unitIndex].MoveTo(new Vector3(destination.x + i * offset, destination.y, destination.z + j * offset), duration);
                    unitIndex++;
                }
            }
        }
    }
}
