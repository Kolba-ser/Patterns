

namespace Patterns.Decorator
{
    public abstract class StatsDecorator : IStatsProvider
    {
        protected readonly IStatsProvider wrappedEntity;

        protected StatsDecorator(IStatsProvider wrappedEntity)
        {
            this.wrappedEntity = wrappedEntity;
        }

        public PlayerStats GetStats() => GetStatsInteranl();

        protected abstract PlayerStats GetStatsInteranl();
    }
}
