using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
public class User
{
    [Display(Name = "First Name:")] 
    [Required]
    [MinLength(3)]
    public string FirstName { get; set; }

    [Display(Name = "Last Name:")]
    [Required]
    [MinLength(4)]
    public string LastName { get; set; }

    
    [Required]
    [Range(1,int.MaxValue)]
    public int Age { get; set; }

    [Display(Name = "Email Address:")]
    [Required]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
}