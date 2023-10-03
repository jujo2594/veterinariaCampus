using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Raza:BaseEntity
{
    [Required]
    public string NombreRaza { get; set; }
    //Se establece la relacion 'uno a uno' entre las tablas 'Mascota' y 'Raza' ya que una mascota solo puede ser de una sola raza en especifico
    public ICollection<Mascota> Mascotas { get; set; }
}
