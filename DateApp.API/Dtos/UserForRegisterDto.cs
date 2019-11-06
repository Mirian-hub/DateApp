using System.ComponentModel.DataAnnotations;

namespace DateApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName {get;set;}
        [Required]
        [StringLength(8, MinimumLength=4,ErrorMessage="Password lenght between 4-8")]
        public string Password {get;set;}
    }
}