using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Cita: BaseEntity
{
    [Required]
    public DateTime Fecha { get; set; }

    [Required]
    public TimeSpan Hora { get; set; }

    [Required]
    public int IdClienteFk { get; set; }
    
    //Se establece la relacion ya que una 'Cita' solo puede estar asignada a un cliente, pero un cliente puede solicitar muchas citas, por eso se define esta relacion como 'uno a muchos'
    public Cliente Clientes { get; set; }

    [Required]
    public int IdMascotaFk { get; set; }

    //Se establece la relacion ya que una 'Cita' solo puede estar asignada a una mascota, pero una mascota puede solicitar muchas citas, por eso se define esta relacion como 'uno a muchos'
    public Mascota Mascotas { get; set; }

    [Required]
    public int IdServicioFk { get; set; }
    //Se define la relación de 'uno a mucho' entre 'cita' y 'servicio' ya que una 'Cita' solo puede estar relacionado a un 'Servicio', pero un 'Servicio' puede estar relacionado a muchas 'Citas'
    public Servicio Servicios { get; set; }

}
