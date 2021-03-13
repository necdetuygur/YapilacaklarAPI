using AutoMapper;
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
    public class YapilacakController : ControllerBase
    {
        private readonly IYapilacakService _yapilacakService;
        private readonly IMapper _mapper;
        public YapilacakController(IYapilacakService yapilacakService, IMapper mapper)
        {
            _yapilacakService = yapilacakService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var yapilacaks = await _yapilacakService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<YapilacakDto>>(yapilacaks));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var yapilacak = await _yapilacakService.GetByIdAsync(id);
            return Ok(_mapper.Map<YapilacakDto>(yapilacak));
        }

        [HttpGet("{id}/Kullanici")]
        public async Task<IActionResult> GetWithKullaniciByIdAsync(int id)
        {
            var yapilacakWithKullanici = await _yapilacakService.GetWithKullaniciByIdAsync(id);
            return Ok(_mapper.Map<YapilacakWithKullaniciDto>(yapilacakWithKullanici));
        }

        [HttpPost]
        public async Task<IActionResult> Save(YapilacakDto yapilacakDto)
        {
            var newYapilacak = await _yapilacakService.AddAsync(_mapper.Map<Yapilacak>(yapilacakDto));
            return Created(string.Empty, _mapper.Map<YapilacakDto>(newYapilacak));
        }

        [HttpPut]
        public IActionResult Update(YapilacakDto yapilacakDto)
        {
            var newYapilacak = _yapilacakService.Update(_mapper.Map<Yapilacak>(yapilacakDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var yapilacak = _yapilacakService.GetByIdAsync(id).Result;
            _yapilacakService.Remove(yapilacak);
            return NoContent();
        }
    }
}
