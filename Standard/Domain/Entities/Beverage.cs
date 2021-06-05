namespace Domain.Entities
{
    public abstract class Beverage
    {
        public int Qtd { get; set; }
        public abstract int Level { get; }

        public int GetTotalDrinkLevel() => Qtd * Level;
    }
}