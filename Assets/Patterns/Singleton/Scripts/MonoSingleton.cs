using UnityEngine;

namespace Patterns.Singleton
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        [SerializeField] private bool lazy;

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    SetInstance();
                }

                return instance;
            }
        }

        private void Awake()
        {
            if (lazy)
                return;

            SetInstance();

        }

        protected virtual void Initialize() { }

        private static void SetInstance()
        {
            var instances = FindObjectsOfType<T>();
            if (instances.Length > 1)
            {
                Debug.LogError($"There must be on instance of the class on the scene {typeof(T)}");
            }
            else if (instances.Length == 0)
            {
                Debug.LogError($"There is no object of type {typeof(T)}");
                return;
            }
            instance = instances[0];
            instance.Initialize();
        }
    }
}