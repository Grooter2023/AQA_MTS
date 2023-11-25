using System.Text;
using static System.Net.Mime.MediaTypeNames;


//Задание 1
/* 
namespace StringApp
{
    static class Program
    {
        static void Main(string[] args)
        {

            string text = "For Example, if a code segment has 10 lines and the test designed by you covers only 5 of them then we can say that statement coverage given by the test is 50%.";
            Console.WriteLine($"Текст оригинальный: {text}");

            string text2 = text.Replace( "test" , "testing");
            Console.WriteLine($"Текст с заменой test testing: {text2}");

            text2 = Regex.Replace(text2, "[0-9]", "", RegexOptions.IgnoreCase);
            Console.WriteLine($"Текст без цифр: {text2}");

            Console.ReadKey();
        }
    }
}
*/



//Задание 2
/* 
namespace StringApp
{
    static class Program
    {
        static void Main(string[] args)
        {

            string texWelcome = "Welcome";
            string texTo = "to";
            string texThe = "the";
            string texTMS = "TMS";
            string texLesons = "lesons";
            const string quote = "\"";

            string summ = texWelcome + texTo + texThe + texTMS + texLesons;

            Console.WriteLine($" {quote}{texWelcome}{quote} {quote}{texTo}{quote} {quote}{texThe}{quote} {quote}{texTMS}{quote} {quote}{texLesons}{quote}.");

            Console.ReadKey();
        }
    }
}

*/


//Задание 3
/* 
 
namespace StringApp
{
    static class Program
    {
        static void Main(string[] args)
        {

            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
        
            var text1 = "abc";
            int IndexForText1 = text.IndexOf(text1);
           
            string text2 = text.Substring(0, IndexForText1);
           
            string text3 = text.Substring(text1.Length);

            Console.WriteLine($"Текст оригинальный: {text}\nТекст ДО abc:{text2} \nТекст ПОСЛЕ abc:{text3}");

               Console.ReadKey();
        }
    }
}
*/



// Задание 4
/* 
namespace StringApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            string name = "Плохой день.";
            name = name.Substring(7);

            int ind = name.Length - 1;
            name = name.Remove(ind);

            string substring = "Хороший "; //Хороший день.
            name = name.Insert(0, substring);

            string substring1 = "!!!!!!!!!"; //Хороший день !!!!!!!!! 
            name = name.Insert(name.Length, substring1);

            int ind1 = name.Length - 1;
            name = name.Remove(ind1);

             string substring2 = "?"; //Хороший день.
             name = name.Insert(name.Length, substring2);

            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
*/


