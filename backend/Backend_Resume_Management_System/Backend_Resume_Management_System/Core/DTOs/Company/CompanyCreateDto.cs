using Backend_Resume_Management_System.Core.Enums;

namespace Backend_Resume_Management_System.Core.DTOs.Company
{
    public class CompanyCreateDto
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }
    }
}
