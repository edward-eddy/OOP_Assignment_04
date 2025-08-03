namespace Task
{
    internal class Food
    {
        public int FreshnessLevel { get; set; }

        public Food(int freshnessLevel)
        {
            FreshnessLevel = freshnessLevel;
        }
        public Food()
        {

        }

        public static Food operator ++(Food food)
        {
            return new Food(++food.FreshnessLevel);
        }

        public void Show()
        {
            Console.WriteLine($"The Freshness Level is : {FreshnessLevel} ");
        }
    }
}
