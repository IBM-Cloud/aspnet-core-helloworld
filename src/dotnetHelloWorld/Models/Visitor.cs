using System.ComponentModel.DataAnnotations;

namespace dotnetHelloWorld.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}