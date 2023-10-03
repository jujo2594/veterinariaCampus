using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class ClienteTelefono:BaseEntity
{   
    //Se declara 'IdClienteFk' como Foreign Key para enlazar la tabla 'ClienteTelefono' con la tabla 'Cliente'
    [Required]
    public int IdClienteFk { get; set; }
    //Se establece la relacion con la tabla 'Cliente' ya que un 'NumeroTelefono' esta relacionado a un solo cliente
    public Cliente Clientes { get; set; }
    
    [Required]
    public string Numero { get; set; }
}
