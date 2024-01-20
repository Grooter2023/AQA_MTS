namespace Exceptions
{
    public class WrongLoginException : Exception 
    {
        //конструктор по умолчанию
        public WrongLoginException() : base() 
        { 
        }
        //конструктор принимает сообщение исключения и передает его в конструктор класса Exception
        public WrongLoginException(string message) : base(message) 
        { 
        }
    }
}
