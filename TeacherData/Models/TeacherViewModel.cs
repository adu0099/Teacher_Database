using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherData.Models
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Department")]
        public string Department { get; set; }
        [DisplayName("Joinning Date")]
        public DateTime JoinDate { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Contact Number")]
        public string Phone { get; set; }
        [DisplayName("Phone")]

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

    }
}
