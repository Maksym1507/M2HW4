namespace M2HW4.Models
{
    public abstract class Animal
    {
        public Animal(string name, int averageAge, double weight)
        {
            Name = name;
            AverageAge = averageAge;
            Weight = weight;
        }

        public string Name { get; set; }

        public int AverageAge { get; set; }

        public double Weight { get; set; }
    }
}
