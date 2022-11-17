namespace Vehiculos20200904.Data.Models;
using System.ComponentModel.DataAnnotations;
public class Vehiculo
{
    [Key]
    public string? vehiculoID { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public double Año { get; set; }
    public string? Color { get; set; }
}