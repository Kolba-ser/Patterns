

using System;

namespace Patterns.Decorator
{
    public class SpecializationStats : StatsDecorator
    {

        private readonly SpecializationType type;

        public SpecializationStats(IStatsProvider wrappedEntity, SpecializationType type) : base(wrappedEntity)
        {
            this.type = type;
        }

        protected override PlayerStats GetStatsInteranl()
        {
            return wrappedEntity.GetStats() + GetSpecialStats();
        }

        private PlayerStats GetSpecialStats()
        {
            switch (type)
            {
                case SpecializationType.Mage:
                    return new PlayerStats()
                    {
                        Agility = 1,
                        Intellegence = 2,
                        Stamina = 0,
                        Strenght = -1
                    };
                    
                case SpecializationType.Warrior:
                    return new PlayerStats()
                    {
                        Agility = 1,
                        Intellegence = 0,
                        Stamina = 3,
                        Strenght = 3
                    };
                case SpecializationType.Archer:
                    return new PlayerStats()
                    {
                        Agility = 2,
                        Intellegence = 0,
                        Stamina = 3,
                        Strenght = 0
                    };
                case SpecializationType.Savage:
                    return new PlayerStats()
                    {
                        Agility = 3,
                        Intellegence = -1,
                        Stamina = 2,
                        Strenght = 1
                    };
                default:
                    throw new NotImplementedException($"SpecializationType {type} does not implemented");

            }
        }
    }
}
