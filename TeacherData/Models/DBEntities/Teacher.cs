using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherData.Models.DBEntities
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime JoinDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
