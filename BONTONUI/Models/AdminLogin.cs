using System.ComponentModel.DataAnnotations;

namespace BONTONUI.Models
{
    public class AdminLogin
    {
        [Required(ErrorMessage = "Employee ID required")]
        public string EmpId { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
    }
}
