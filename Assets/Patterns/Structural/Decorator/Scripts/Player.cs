using System;
using UnityEngine;

namespace Patterns.Decorator
{
    public sealed class Player : MonoBehaviour
    {
        [field: SerializeField] public RaceType Race { get; private set; }
        [field: SerializeField] public SpecializationType Specialization { get; private set; }

        private IStatsProvider provider;

        public event Action<IStatsProvider> OnRaceChosed;

        private void Start()
        {
            provider = new RaceStats(Race);
            provider = new SpecializationStats(provider, Specialization);

            OnRaceChosed?.Invoke(provider);
        }
    }
}
