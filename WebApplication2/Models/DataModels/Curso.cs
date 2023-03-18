using System.ComponentModel.DataAnnotations;

namespace APIOpenBootcamp.Models.DataModels
{
    public enum Nivel
    {
        Basic,
        Intermediate,
        Advanced
    }
    public class Curso : BaseEntity
    {
        [Required][MaxLength(280)] public string name { get; set; } = string.Empty;
        [Required][MaxLength(280)] public string shortDescription { get; } = string.Empty;
        [Required] public string LargeDescription { get; set; } = string.Empty;

        [Required] public string publicoObjectives { get;  set; } = string.Empty;

        [Required]  public string objectives { get;set; } = string.Empty;

        [Required] public string requirements { get; set; } = string.Empty;

        [Required] public Nivel level { get; set; }  

        
    }
}
