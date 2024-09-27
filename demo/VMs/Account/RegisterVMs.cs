using System.ComponentModel.DataAnnotations;

namespace presentationLayer_Controller.VMs.Account
{
    public class RegisterVMs
    {
        [Required(ErrorMessage = " UserName is required")]
        [StringLength(250, ErrorMessage = "UserName cannot be longer than 250 characters")]
        [Display(Name = " Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " Type Of User is required")]
        [Display(Name = " TypeOfUser")]
        public string TypeOfUser { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = " Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = " PhoneNumber")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
