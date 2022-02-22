namespace Abstraindo_Jogo_RPG_POO_CSharp.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public virtual string Attack()
        {
            return Name + " attacked with your sword!";
        }

        public override string ToString()
        {
            return Name + ", " + Level + ", " + HeroType;
        }
    }
}