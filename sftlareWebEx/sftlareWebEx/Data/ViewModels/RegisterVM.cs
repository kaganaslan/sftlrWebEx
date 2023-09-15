using System.ComponentModel.DataAnnotations;

namespace sftlareWebEx.Data.ViewModels
{
    public class RegisterVM
    {

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name ="Email address")]
        [Required(ErrorMessage ="Email address is required")]
        public string  EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "Password can be maximum 32 character", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&.])[A-Za-z\d$@$!%*?&.]{6,32}$",
            ErrorMessage = "At least 1 Uppercase, 1 lowe case, 1 number, 1 special character( @, !, %, *, ?, &, .) contain and can be maximum 32 character.")]
        public string Password { get; set; }


        [Display(Name ="Confirm password")]
        [Required(ErrorMessage ="Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
