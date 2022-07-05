using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using WordSharedCodeLibrary;
namespace LiteraAPPServices.Services
{
    public class WordService
    {
        public string GetHighlightedTextUnicode(string value)
        
        {
            string processedText = WordOperations.GetHighlightedTextUnicode(value);
                        
            return processedText;
        }
    }
}
