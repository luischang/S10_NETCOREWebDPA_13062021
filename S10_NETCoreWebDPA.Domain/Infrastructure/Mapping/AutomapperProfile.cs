using AutoMapper;
using S10_NETCoreWebDPA.Domain.Core.DTOs;
using S10_NETCoreWebDPA.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_NETCoreWebDPA.Domain.Infrastructure.Mapping
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            CreateMap<CustomerPostDTO, Customer>();


        }
    }
}
