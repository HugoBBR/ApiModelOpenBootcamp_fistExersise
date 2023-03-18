using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.DataModels
{
    public class User:BaseEntity
    {
        [Required] public string UserName { get; set; } = string.Empty;

        [Required] public string name { get;set;} = string.Empty;

        [Required] public string email { get; set; } = string.Empty;    

        [Required] public string Password { get; set; } = string.Empty;
    }
}
