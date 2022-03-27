using System.ComponentModel.DataAnnotations;

namespace RestfulApiWithEFCore.Models.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string ?FirstName { get; set; } // '?' its meaning it can be null
        public string ?LastName { get; set; }
    }
}
