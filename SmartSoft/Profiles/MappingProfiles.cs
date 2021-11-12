using AutoMapper;
using Entities.DTO;
using Entities.DTO.User_Warehouse;
using Entities.DTO.Warehouse;
using Entities.Model.User;
using Entities.Model.User_Warehouse;
using Entities.Model.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSoft.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<UserDTO, User>();
            CreateMap<WarehouseDTO, Warehouse>();
            CreateMap<User_WarehouseAddDTO, User_Warehouse>();
        }
    }
}
