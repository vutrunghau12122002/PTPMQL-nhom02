using System.Net.NetworkInformation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreMVC.Models
{
   [Table ("Person")]

  public class Person
    {
        [Key]
        public string PersonId {get;set;}
        public string Fullname {get;set;}
        public string Address {get;set;}
        public string? Title { get;set; }
    }
}   


    
