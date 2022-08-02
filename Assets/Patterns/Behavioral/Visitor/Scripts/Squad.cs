using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public sealed class Squad : IMovableEntity
    {
        private List<Unit> unitsInSquad;
        public List<Unit> Units => unitsInSquad;

        private readonly float offset = 1f;

        public Squad(List<Unit> units)
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

        public void Accept(IMovableEntityVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
