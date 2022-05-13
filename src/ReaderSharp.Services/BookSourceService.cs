using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReaderSharp.Controllers.DynamicAPI;
using ReaderSharp.Data;
using ReaderSharp.Models.Dtos;
using ReaderSharp.Models.Entities;

namespace ReaderSharp.Services
{
    [APIService("BookSource")]
    public class BookSourceService : ControllerBase
    {
        private readonly IBookSourceManager _manager;
        private readonly IMapper _mapper;

        public BookSourceService(IBookSourceManager bookSourceManager, IMapper mapper)
        {
            _manager = bookSourceManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ImportBookSourceDto>>> GetBookSource()
        {
            var sources = await _manager.GetBookSource();
            return Ok(_mapper.Map<List<ImportBookSourceDto>>(sources));
        }


        [HttpPost]
        public async Task<IActionResult> ImportBookSource([FromBody] List<ImportBookSourceDto> sources)
        {
            var convertedSources = _mapper.Map<List<BookSource>>(sources);
            await _manager.ImportBookSource(convertedSources);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookSource([FromBody] List<string> baseUrls)
        {
            await _manager.DeleteBookSource(baseUrls);
            return Ok();
        }
    }
}
