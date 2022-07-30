using UnityEngine;

namespace Patterns.Composite
{
    public sealed class SquadMover
    {
        private CameraRaycaster cameraRaycaster;
        private Squad squad;
        private float duration;

        public SquadMover(CameraRaycaster cameraRaycaster, Squad squad, float duration)
        {
            this.cameraRaycaster = cameraRaycaster;
            this.squad = squad;
            this.duration = duration;

            cameraRaycaster.OnRayHitted += MoveSquad;
        }

        private void MoveSquad(Vector3 destination)
        {
            squad.MoveTo(destination, duration);
        }
    }
}
