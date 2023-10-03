using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Ciudad : BaseEntity
    {
        [Required]
        public string NombreCiudad { get; set; }
        [Required]
        public int IdDepartamentoFk { get; set; }

        public Departamento Departamentos { get; set; }

        public ICollection<ClienteDireccion> ClientesDirecciones { get; set; }
    }
