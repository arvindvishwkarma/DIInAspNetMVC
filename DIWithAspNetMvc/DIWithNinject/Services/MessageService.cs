using DIWithNinject.Infrastructure;

namespace DIWithNinject.Services
{
    public class MessageService:IMessageService
    {
        public string GetMessage()
        {
            return "Hello, This is message service";
        }
    }
}