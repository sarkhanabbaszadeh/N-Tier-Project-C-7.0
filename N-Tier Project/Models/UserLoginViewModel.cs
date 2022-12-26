using System.ComponentModel.DataAnnotations;

namespace N_Tier_Project.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Zəhmət olmasa istifadəçi adınızı daxil edin")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Zəhmət olmasa şifrəni daxil edin")]
        public string Password { get; set; }
    }
}
