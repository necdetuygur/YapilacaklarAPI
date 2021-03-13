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

            CreateMap<KullaniciWithYapilacakDto, Kullanici>();
            CreateMap<Kullanici, KullaniciWithYapilacakDto>();

            CreateMap<YapilacakDto, Yapilacak>();
            CreateMap<Yapilacak, YapilacakDto>();

            CreateMap<YapilacakWithKullaniciDto, Yapilacak>();
            CreateMap<Yapilacak, YapilacakWithKullaniciDto>();
        }
    }
}
