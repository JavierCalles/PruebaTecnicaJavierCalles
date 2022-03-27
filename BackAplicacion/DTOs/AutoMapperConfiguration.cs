using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackAplicacion.Models;

namespace BackAplicacion.DTOs
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                
                cfg.CreateMap<Cliente, ClienteDto>().
                ForMember(x => x.priApe, o => o.MapFrom(s => s.SegundoNombre)).
                ForMember(x => x.priNom, o => o.MapFrom(s => s.PrimerNombre))
                   .ReverseMap();

              
            });
        }

    }
}
