using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Cliente:BaseEntity
{   
    //Se le indica a los atributos que son requeridos o obligatorios dentro de la estructura de la base de datos
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Apellidos { get; set; }
    [Required]
    public string Email { get; set; }

    //Se establece la relacion uno a uno con la tabla 'ClienteDireccion', ya que un 'Cliente' solo puede estar relacionado a una dirección de residencia.
    public ClienteDireccion ClientesDirecciones{ get; set; }

    //Se establece la relacion uno a muchos con la tabla 'ClienteTelefono' ya que un 'Cliente' puede tener muchos numeros telefonicos en nuestra base de datos.
    public ICollection<ClienteTelefono> ClientesTelefonos { get; set; }

    //Se establece la relacion uno a muchos con la tabla 'Mascota' ya que un 'Cliente' puede tener muchas Mascotas relacionadas en nuestra base de datos.
    public ICollection<Mascota> Mascotas { get; set; }

    //Se establece una relacion 'uno a muchos' con la tabla 'Citas' ya que un 'Cliente' puede solicitar muchas citas

    public ICollection<Cita> Citas { get; set; }
}
