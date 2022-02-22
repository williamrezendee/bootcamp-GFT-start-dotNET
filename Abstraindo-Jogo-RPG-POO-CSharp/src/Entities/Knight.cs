namespace Abstraindo_Jogo_RPG_POO_CSharp.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return base.Attack();
        }
    }
}