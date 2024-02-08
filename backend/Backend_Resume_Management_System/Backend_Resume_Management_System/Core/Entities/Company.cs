using Backend_Resume_Management_System.Core.Enums;

namespace Backend_Resume_Management_System.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        // Relations
        public ICollection<Job> Jobs { get; set; }
    }
}
