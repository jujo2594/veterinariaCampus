using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles
{
    // La clase debe heredar de 'Profile' tambien es necesario el paquete 'AutoMapper'
    public class MappingProfiles : Profile
    {
        protected MappingProfiles()
        {
            //'.ReverseMap' permite pasar de Entidad a DTO y de DTO a Entidad
            CreateMap<Pais, PaisDto>()
            .ReverseMap();
        }
    }
}

//Mapear la dirección con solo la informacion principal.