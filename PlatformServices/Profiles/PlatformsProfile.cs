using AutoMapper;
using PlatformServices.Dtos;
using PlatformServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformServices.Profiles
{
    public class PlatformsProfile:Profile
    {
        public PlatformsProfile()
        {
            //source ---> to Target

            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
