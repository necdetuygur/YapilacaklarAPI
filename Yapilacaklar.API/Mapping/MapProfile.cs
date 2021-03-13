using AutoMapper;
using Yapilacaklar.API.DTOs;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Kullanici, KullaniciDto>();
            CreateMap<KullaniciDto, Kullanici>();
        }
    }
}
