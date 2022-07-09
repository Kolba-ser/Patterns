
using TMPro;
using UnityEngine;

namespace Patterns.Decorator
{
    public sealed class StatsView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI raceContent;
        [SerializeField] private TextMeshProUGUI specializationContent;

        [Space(20)]
        [SerializeField] private TextMeshProUGUI agilityContent;
        [SerializeField] private TextMeshProUGUI strengthContent;
        [SerializeField] private TextMeshProUGUI intellegenceContent;
        [SerializeField] private TextMeshProUGUI staminaContent;

        public void UpdateStats(PlayerStats stats)
        {
            agilityContent.text = stats.Agility.ToString();
            staminaContent.text = stats.Stamina.ToString();
            strengthContent.text = stats.Strenght.ToString();
            intellegenceContent.text = stats.Intellegence.ToString();
        }

        public void UpdateRaceSpecialization(RaceType race, SpecializationType specialization)
        {
            raceContent.text = race.ToString();
            specializationContent.text = specialization.ToString();
        }
    }
}
