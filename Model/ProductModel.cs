using System.ComponentModel.DataAnnotations;

namespace CreateWebapi.Model{
public class Vehicle{
    [Key]
    public int VehicleId{get;set;} 
    [Required]
    public string? OwnerName{get;set;}
    [Required]
     public string? Vehiclename{get;set;}
     [Required]
    public string? Vehicletype{get;set;}
}
}