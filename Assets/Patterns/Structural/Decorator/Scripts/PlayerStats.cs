
namespace Patterns.Decorator
{
    public class PlayerStats 
    {
        public int Strenght {get; set; }
        public int Agility {get; set; }
        public int Intellegence {get; set; }
        public int Stamina {get; set; }

        public static PlayerStats operator +(PlayerStats a, PlayerStats b)
        {
            return new PlayerStats()
            {
                Strenght = a.Strenght + b.Strenght,
                Agility = a.Agility + b.Agility,
                Intellegence = a.Intellegence + b.Intellegence,
                Stamina = a.Stamina + b.Stamina
            };
        }
        public static PlayerStats operator *(PlayerStats a, PlayerStats b)
        {
            return new PlayerStats()
            {
                Strenght = a.Strenght * b.Strenght,
                Agility = a.Agility * b.Agility,
                Intellegence = a.Intellegence * b.Intellegence,
                Stamina = a.Stamina * b.Stamina
            };
        }
    }
}
