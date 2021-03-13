using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yapilacaklar.API.DTOs;
using Yapilacaklar.Core.Services;

namespace Yapilacaklar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _kullaniciService;
        private readonly IMapper _mapper;
        public KullaniciController(IKullaniciService kullaniciService, IMapper mapper)
        {
            _kullaniciService = kullaniciService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var kullanicis = await _kullaniciService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<KullaniciDto>>(kullanicis));
        }
    }
}
