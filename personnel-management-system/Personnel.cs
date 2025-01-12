using System.ComponentModel.DataAnnotations.Schema;

namespace personnel_management_system
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Ssn { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
        public DateTime StartDate { get; set; }
        public bool IsOnDuty { get; set; }
    }
}
