using Backend_Resume_Management_System.Core.Enums;

namespace Backend_Resume_Management_System.Core.DTOs.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }
}
