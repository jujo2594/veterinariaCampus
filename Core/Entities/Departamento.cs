using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Departamento : BaseEntity
{
    [Required]
    public string NombreDepartamento { get; set; }
    [Required]
    public int IdPaisFk { get; set; }

    public Pais Paises { get; set; }

    public ICollection<Ciudad> Ciudades { get; set; }

}
