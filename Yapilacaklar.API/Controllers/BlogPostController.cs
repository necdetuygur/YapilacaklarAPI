using AutoMapper;
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
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IMapper _mapper;
        public BlogPostController(IBlogPostService BlogPostService, IMapper mapper)
        {
            _blogPostService = BlogPostService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var BlogPosts = await _blogPostService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<BlogPostDto>>(BlogPosts));
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var BlogPost = await _blogPostService.GetByIdAsync(id);
            return Ok(_mapper.Map<BlogPostDto>(BlogPost));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Save(BlogPostDto BlogPostDto)
        {
            var newBlogPost = await _blogPostService.AddAsync(_mapper.Map<BlogPost>(BlogPostDto));
            return Created(string.Empty, _mapper.Map<BlogPostDto>(newBlogPost));
        }

        [Authorize]
        [HttpPut]
        public IActionResult Update(BlogPostDto BlogPostDto)
        {
            var newBlogPost = _blogPostService.Update(_mapper.Map<BlogPost>(BlogPostDto));
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var BlogPost = _blogPostService.GetByIdAsync(id).Result;
            _blogPostService.Remove(BlogPost);
            return NoContent();
        }
    }
}
