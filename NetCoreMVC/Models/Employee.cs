using NetCoreMVC.Models;

namespace NetCoreMvc.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}