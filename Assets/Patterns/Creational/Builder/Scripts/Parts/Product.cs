using UnityEngine;

namespace Patterns.Builder
{
    public abstract class Product : MonoBehaviour
    {
        [SerializeField] protected string name;
        [SerializeField, Min(0)] protected int cost;
        [SerializeField] private Renderer renderer;
        public string Name => name;
        public int Cost => cost;
        public float Height => renderer.bounds.size.y;

        public void OnDrawGizmosSelected()
        {
            if (renderer == null)
                return;
            var bounds = renderer.bounds;
            Gizmos.matrix = Matrix4x4.identity;
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(bounds.center, bounds.extents * 2);
        }
    }
}
