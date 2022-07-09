using UnityEngine;

namespace Patterns.Decorator
{
    public sealed class StatsPresenter : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private StatsView view;

        private void OnEnable()
        {
            player.OnRaceChosed += UpdateView;
        }

        private void OnDisable()
        {
            
            player.OnRaceChosed -= UpdateView;
        }

        private void UpdateView(IStatsProvider provider)
        {
            view.UpdateStats(provider.GetStats());
            view.UpdateRaceSpecialization(player.Race, player.Specialization);
        }
    }
}
