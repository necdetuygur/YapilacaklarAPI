﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yapilacaklar.API.DTOs;
using Yapilacaklar.Core.Models;
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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var kullanicis = await _kullaniciService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<KullaniciDto>>(kullanicis));
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var kullanici = await _kullaniciService.GetByIdAsync(id);
            return Ok(_mapper.Map<KullaniciDto>(kullanici));
        }

        [Authorize]
        [HttpGet("{id}/Yapilacaks")]
        public async Task<IActionResult> GetWithYapilacaksByIdAsync(int id)
        {
            var kullaniciWithYapilacakDto = await _kullaniciService.GetWithYapilacaksByIdAsync(id);
            return Ok(_mapper.Map<KullaniciWithYapilacakDto>(kullaniciWithYapilacakDto));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Save(KullaniciDto kullaniciDto)
        {
            var newKullanici = await _kullaniciService.AddAsync(_mapper.Map<Kullanici>(kullaniciDto));
            return Created(string.Empty, _mapper.Map<KullaniciDto>(newKullanici));
        }

        [Authorize]
        [HttpPut]
        public IActionResult Update(KullaniciDto kullaniciDto)
        {
            var newKullanici = _kullaniciService.Update(_mapper.Map<Kullanici>(kullaniciDto));
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var kullanici = _kullaniciService.GetByIdAsync(id).Result;
            _kullaniciService.Remove(kullanici);
            return NoContent();
        }
    }
}
