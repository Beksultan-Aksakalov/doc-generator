using document_generator.Models;
using document_generator.Razmetka;
using Microsoft.AspNetCore.Mvc;
using MigraDocCore.Rendering;
using System.IO;

namespace document_generator.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentAutoController : ControllerBase
    {

        [HttpPost]
        [Route("auto")]
        public IActionResult Post([FromBody] PowerOfAttorneyAutoSaleDocument doc)
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
        public IActionResult Post([FromBody] AutoSaleDocument doc)
        {
            var document = AutoRazmetka.getAutoSaleDoc(doc);
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
