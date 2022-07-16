namespace helloWorldSiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD!");

            string name = "Laura Valentina";
            int age = 25;
            int heigth = 163;
            string information = "Hello user, the reguest info is: \nName: " + name +"\nAge: "+age+"\nHeigth: "+heigth;

            Console.WriteLine(information); 
        }
    }
}