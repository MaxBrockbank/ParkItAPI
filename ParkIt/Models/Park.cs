using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ParkIt.Models
{
  public class Park
  {
    public int ParkId{get;set;}
    [Required]
    public string Name{get;set;}
    [Required]
    public string State{get;set;}
    [Required]
    public string ParkType{get;set;}
  }
}