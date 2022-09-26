using M2HW4.Interfaces;

namespace M2HW4.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
