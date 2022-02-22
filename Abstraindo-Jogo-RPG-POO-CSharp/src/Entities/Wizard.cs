namespace Abstraindo_Jogo_RPG_POO_CSharp.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return Name + " threw your spell!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return Name + " thew your spell with bonus of " + bonus;
            else
                return Name + " thew your spell with bonus of " + bonus;
        }
    }
}