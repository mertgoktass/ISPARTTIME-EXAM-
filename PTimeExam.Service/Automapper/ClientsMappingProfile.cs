using AutoMapper;
using FinalExam.Dal.Models;
using FinalExam.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Service.Automapper
{
    public class ClientsMappingProfile : Profile
    {
        public ClientsMappingProfile()
        {
            CreateMap<Clients, ClientsGetDto>();
            CreateMap<ClientsPostPutDto, Clients>();
        }
    }
}
