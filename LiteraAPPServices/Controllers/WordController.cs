using LiteraAPPServices.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiteraAPPServices.Controllers
{

    [ApiController]
    [Route("/api/Word")]
    public class WordController : Controller
    {
        private readonly WordService wordService;

        public WordController(WordService _wordService)
        {
            wordService= _wordService;

        }

        [HttpGet("{id=value}")]
        public IActionResult GetHighlightedText(string value)
        {
            return Ok(wordService.GetHighlightedTextUnicode(value));
        }
    }
}
