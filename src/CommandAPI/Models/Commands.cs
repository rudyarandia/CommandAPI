using System.ComponentModel.DataAnnotations;
namespace CommandAPI.Models
{
  public class Command
  {
    [Key]
    [Required]  
    public int Id {get; set;}
    [Required]
    [MaxLength(250)]
    public string HowTo {get; set;}
    //[required]
    public string Platform {get; set;}
    //[required]
    public string CommandLine {get; set;}
  }
}