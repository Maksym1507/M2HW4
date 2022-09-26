using M2HW4.Extensions;
using M2HW4.Interfaces;
using M2HW4.Models;

namespace M2HW4
{
    public class Starter
    {
        public Starter(INotificationService message)
        {
            Message = message;
        }

        private INotificationService Message { get; }

        public void Run()
        {
            var husky = new Husky("Tobi", 123, 67.7, 18, "Round", 12);
            var spitz = new Spitz("Rex", 200, 677, 18, "Oval", 100);

            Dog[] dogs = { spitz, husky };
            var dog = ArrayExtention.SearchByAverageAge(dogs);

            Message.ShowMessage("Enter dog which has the biggest average age:");

            Message.ShowMessage(dog.ToString());

            dog.DoBark();
        }
    }
}
