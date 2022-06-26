using System;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public abstract class Statue : MonoBehaviour
    {
        private void Start()
        {
            Build();
        }

        protected abstract void Build();
    }
}
