using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Resources;
using Supermarket.API.Domain.Models;
using AutoMapper;


namespace Supermarket.API.Mapping
{
    public class ResourceToModelProfile: Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>(); 
        }
    }
}
