using UnityEngine;

namespace Patterns.Visitor
{
    public sealed class EntityPainter : IMovableEntityVisitor
    {
        private Material squadMaterial;
        private Material unitMaterial;

        public EntityPainter(Material squadMaterial, Material unitMaterial)
        {
            this.squadMaterial = squadMaterial;
            this.unitMaterial = unitMaterial;
        }

        public void Visit(Squad squad)
        {
            foreach (var unit in squad.Units)
            {
                unit.GetComponent<MeshRenderer>().sharedMaterial = squadMaterial;
            }
        }

        public void Visit(Unit unit)
        {
            unit.GetComponent<MeshRenderer>().sharedMaterial = unitMaterial;

        }
    }
}
