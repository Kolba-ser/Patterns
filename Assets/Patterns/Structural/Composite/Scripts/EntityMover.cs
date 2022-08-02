using UnityEngine;

namespace Patterns.Composite
{
    public sealed class EntityMover
    {
        private CameraRaycaster cameraRaycaster;
        private IMovableEntity entity;
        private float duration;

        public EntityMover(CameraRaycaster cameraRaycaster, IMovableEntity entity, float duration)
        {
            this.cameraRaycaster = cameraRaycaster;
            this.entity = entity;
            this.duration = duration;

            cameraRaycaster.OnRayHitted += MoveSquad;
        }

        private void MoveSquad(Vector3 destination)
        {
            entity.MoveTo(destination, duration);
        }
    }
}
