using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReaderSharp.Web.API.Models.Dtos;
using ReaderSharp.Web.API.Models.Entities;
using ReaderSharp.Web.API.Services.DynamicAPI;
using ReaderSharp.Web.Data;

namespace ReaderSharp.Web.API.Services
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
        public async Task<ActionResult<List<ImportBookSourceDto>>> Get()
        {
            var sources = await _manager.GetBookSource();
            return Ok(_mapper.Map<List<ImportBookSourceDto>>(sources));
        }


        [HttpPost]
        public async Task<IActionResult> Import([FromBody] List<ImportBookSourceDto> sources)
        {
            var convertedSources = _mapper.Map<List<BookSource>>(sources);
            await _manager.ImportBookSource(convertedSources);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] List<string> baseUrls)
        {
            await _manager.DeleteBookSource(baseUrls);
            return Ok();
        }
    }
}
