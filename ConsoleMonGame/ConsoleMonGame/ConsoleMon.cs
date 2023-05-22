using System.Globalization;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name = "Will";

        internal void TakeDamage(int Damage)
        {
            health -= Damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}