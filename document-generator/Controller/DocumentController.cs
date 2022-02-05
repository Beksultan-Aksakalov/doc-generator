﻿using document_generator.Model;
using document_generator.Razmetka;
using Microsoft.AspNetCore.Mvc;
using MigraDocCore.Rendering;
using System.IO;

namespace document_generator.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {

        [HttpPost]
        [Route("auto")]
        public IActionResult Post([FromBody]AutoDocument doc)
        {
            var document = AutoRazmetka.getAutoDoc(doc);
            document.UseCmykColor = true;
            
            const bool unicode = true;
            var pdfRenderer = new PdfDocumentRenderer(unicode);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            var stream = new MemoryStream();
            pdfRenderer.PdfDocument.Save(stream);

            return File(stream, "application/pdf");
        }

        [HttpGet]
        public string get()
        {

            return "fuck";
        }
    }
}