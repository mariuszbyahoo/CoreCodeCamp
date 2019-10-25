using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class TalkProfile : Profile
    {
        public TalkProfile()
        {
            this.CreateMap<Talk, TalkModel>()
                .ForMember(c => c.Title, o => o.MapFrom(m => m.Title))
                .ReverseMap()
                .ForMember(t => t.Camp, opt => opt.Ignore())
                .ForMember(t => t.Speaker, opt => opt.Ignore());
        }
    }
}
