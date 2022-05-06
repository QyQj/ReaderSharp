using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReaderSharp.Controllers.DynamicAPI;
using ReaderSharp.Data;

namespace ReaderSharp.Services
{
    [APIService]
    public class BookSourceService : ControllerBase
    {
        private readonly IBookSourceManager _manager;

        public BookSourceService(IBookSourceManager bookSourceManager)
        {
            _manager=bookSourceManager;
        }
    }
}
