using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Servicio:BaseEntity
{
    [Required]
    public string Nombre { get; set; }

    [Required]
    public double Precio { get; set; }

    //Un servicio puede estar relacionado con muchas citas, por lo tanto de define una relacion 'uno a muchos'
    public ICollection<Cita> Citas { get; set; }
}
