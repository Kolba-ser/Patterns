using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Patterns.Composite
{
    [RequireComponent(typeof(Camera))]
    public sealed class CameraRaycaster : MonoBehaviour
    {
        private Camera camera;

        public event Action<Vector3> OnRayHitted;

        private void Awake()
        {
            camera = GetComponent<Camera>();
        }

        private void OnDestroy()
        {
            OnRayHitted = null;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit hit;
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit) && hit.collider)
                {
                    OnRayHitted?.Invoke(hit.point);
                }
            }
        }

    }
}
