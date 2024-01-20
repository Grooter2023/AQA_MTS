namespace Exceptions
{
    public class WrongPasswordException : Exception 
    {
        //конструктор по умолчанию
        public WrongPasswordException() : base() 
        { 
        }
        //конструктор принимает сообщение исключения и передает его в конструктор класса Exception
        public WrongPasswordException(string message) : base(message) 
        { 
        }
    }
}
