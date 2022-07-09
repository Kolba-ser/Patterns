
using System;

namespace Patterns.Decorator
{
    public class RaceStats : IStatsProvider
    {

        private readonly RaceType type;

        public RaceStats(RaceType type)
        {
            this.type = type;
        }

        public PlayerStats GetStats()
        {
            switch (type)
            {
                case RaceType.Orc:
                    return new PlayerStats()
                    {
                        Stamina = 3,
                        Agility = 2,
                        Strenght = 4,
                        Intellegence = 1,
                    };
                case RaceType.Human:
                    return new PlayerStats()
                    {
                        Stamina = 4,
                        Agility = 2,
                        Strenght = 2,
                        Intellegence = 3,
                    };
                case RaceType.HellEmployee:
                    return new PlayerStats()
                    {
                        Stamina = 3,
                        Agility = 2,
                        Strenght = -3,
                        Intellegence = 5,
                    };
                default:
                    throw new NotImplementedException($"RaceType {type} does not implemented");
            }
        }
    }
}
