namespace NewApp
{
    public class Person
    {
        public string MaNV{get;set;}
        public string FullName {get;set;}
        public string Age {get;set;}
        public string Luong {get;set;}
        public void EnterData()
        {
            System.Console.Write ("MaNV =");
            MaNV = Console.RealLine();
            System.Console.Write ("FullName =");
            FullName = Console.RealLine();
            System.Console.Write ("Age =");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write ("Luong =");
            Luong = Console.RealLine();
        }
        public void Display()
        {
            System.Console.WriteLine ("{0} -{1} - {2}tuoi - {3}VND" , FullName , Address , Age , Luong);
        }
    }
}