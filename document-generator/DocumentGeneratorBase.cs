using MigraDocCore.DocumentObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace document_generator
{
    public abstract class DocumentGeneratorBase
    {
        public static string NOTARY_NAME = "ИП НОТАРИУС";
        public static string NOTARY_LICENSE_NUMBER = "0001727";
        public static string NOTARY_LICENSE_ISSUE_DATE = "06.12.2003";
        public static string NOTARY_LICENSE_ISSUE_DATE_IN_WORDS = "06 декабря 2003"; // в прописью 
        public static string NOTARY_LICENSE_ISSUED_BY = "Министерством  Юстиции  Республики  Казахстан"; // кем выданной  
        public static string NOTARY_LICENSE_ISSUED_BY_ABBR = "МЮ РК"; // сокращенно
        public static string LAWYER_FULL_NAME = "Сарыбасова Сара Сапарбековна";
        public static string LAWYER_FULL_NAME_INITIAL = "С.С Сарыбасова";
        public static string LAWYER_FULL_NAME_BY_WHOM = "Сарыбасовой Сарой Сапарбековной";


        public static void Paragraph(Paragraph paragraph, ParagraphAlignment alignment, Underline underline) {

            paragraph.Format.Alignment = alignment;
            paragraph.Format.Font.Bold = true;
            paragraph.Format.Font.Italic = true;
            paragraph.Format.LineSpacingRule = LineSpacingRule.Single;
            paragraph.Format.Font.Underline = underline;

        }
    }
}
