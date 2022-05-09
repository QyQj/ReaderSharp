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

        public async Task<IActionResult> ImportBookSource([FromBody] List<ImportBookSourceDto> sources)
        {
            var convertedSources = _mapper.Map<List<BookSource>>(sources);
            await _manager.ImportBookSource(convertedSources);
            return Ok();
        }
    }
}
