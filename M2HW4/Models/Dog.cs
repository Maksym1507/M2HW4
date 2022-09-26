using M2HW4.Interfaces;

namespace M2HW4.Models
{
    public class Dog : Mammal, IBark
    {
        public Dog(string name, int averageAge, double weight, int quantityOfTeeth, string earShape)
            : base(name, averageAge, weight, quantityOfTeeth)
        {
            EarShape = earShape;
        }

        public string EarShape { get; set; }

        public virtual void DoBark()
        {
            Console.WriteLine("I can bark");
        }
    }
}
