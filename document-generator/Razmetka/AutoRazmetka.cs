using System;
using document_generator.Model;
using MigraDocCore.DocumentObjectModel;
using MigraDocCore.DocumentObjectModel.Tables;

namespace document_generator.Razmetka
{
    public class AutoRazmetka
    {
        public static Document getAutoDoc(AutoDocument autoDoc)
        {

            Document document = new Document();
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 13;

            Section section = document.AddSection();
            section.PageSetup.RightMargin = Unit.FromMillimeter(10);
            section.PageSetup.LeftMargin = Unit.FromMillimeter(10);
            section.PageSetup.TopMargin = Unit.FromMillimeter(10);
            section.PageSetup.BottomMargin = Unit.FromMillimeter(10);


            Paragraph paragraph = section.AddParagraph();


            paragraph.AddFormattedText("Name: " + autoDoc.name + " FullName: " + autoDoc.surname);


            return document;
        }
    }
}
