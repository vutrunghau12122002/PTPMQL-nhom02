namespace NewApp
{
    public class Person
    {
        public string FullName {get;set;}
        public string Address {get;set;}
        public string Age {get;set;}
        public void EnterData()
        {
            System.Console.Write ("FullName =");
            FullName = Console.RealLine();
            System.Console.Write ("Address =");
            Address = Console.RealLine();
            System.Console.Write ("Age =");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine ("{0} -{1} - {2}tuoi" , FullName, Address , Age);
        }
    }
}