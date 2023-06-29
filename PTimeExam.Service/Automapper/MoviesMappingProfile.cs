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
    public class MoviesMappingProfile : Profile
    {
        public MoviesMappingProfile()
        {
            CreateMap<Movies, MoviesGetDto>();
            CreateMap<MoviesPostPutDto, Movies>();
        }
    }
}
