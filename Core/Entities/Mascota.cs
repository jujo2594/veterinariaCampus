using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Mascota:BaseEntity
{
    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Especie { get; set; }

    [Required]
    public int IdRazaFk { get; set; }
    //Se establece la relacion 'uno a uno' entre las tablas 'Mascota' y 'Raza' ya que una raza solo puede estar relacionada con una mascota
    public Raza Razas{ get; set; }

    [Required]
    public DateTime FechaNacimiento { get; set; }

    [Required]
    public int IdClienteFk { get; set; }

    //Se establece la relacion con la tabla 'Cliente' ya que una 'Mascota' esta relacionada a un cliente
    public Cliente Clientes { get; set; }

    public ICollection<Cita> Citas { get; set; }
}
