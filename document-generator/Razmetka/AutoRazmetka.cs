using System;
using document_generator.Models;
using MigraDocCore.DocumentObjectModel;
using MigraDocCore.DocumentObjectModel.Tables;

namespace document_generator.Razmetka
{
    public class AutoRazmetka
    {
        public static Document getAutoDoc(PowerOfAttorneyAutoSaleDocument doc)
        {

            Document document = new Document();
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            

            Section section = document.AddSection();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.Orientation = Orientation.Portrait;
            //section.PageSetup.PageHeight = Unit.FromCentimeter(21);
            //section.PageSetup.PageWidth = Unit.FromCentimeter(18);
            section.PageSetup.TopMargin = Unit.FromMillimeter(19);
            section.PageSetup.BottomMargin = Unit.FromMillimeter(12.7);
            section.PageSetup.LeftMargin = Unit.FromMillimeter(22.5);
            section.PageSetup.RightMargin = Unit.FromMillimeter(25);


            var paragraphHeader = section.AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphHeader, ParagraphAlignment.Center, Underline.Single);          
            paragraphHeader.AddFormattedText("ДОВЕРЕННОСТЬ \n СЕНІМХАТ \n", new Font("Times New Roman", 16));
            paragraphHeader.AddFormattedText("\n Южно – Казахстанская область Толебийский  район город Ленгер. \n", new Font("Times New Roman", 12));

            paragraphHeader.Format.Font.Size = Unit.FromMillimeter(4);
            paragraphHeader.AddFormattedText("Две тысячи семнадцатого года девятнадцатого июля.", TextFormat.NoUnderline);


            var paragraphContent = section.AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContent, ParagraphAlignment.Justify, Underline.None);          
            paragraphContent.AddFormattedText("\n Я, гражданин (ка) "
                + doc.SellerFullName + ", "
                + doc.SellerBirthDate + " г. р., уроженки "
                + doc.SellerBirthPlace + " /ИИН "
                + doc.SellerIIN + "/, проживающий (ая) по адресу: "
                + doc.SellerTheActualAddress + ". \n настоящей доверенностью уполномочиваю гр. "
                + doc.CustomerFullName + ", " 
                + doc.CustomerBirthDate + " г. р., "
                + doc.CustomerBirthPlace + " /ИИН "
                + doc.CustomerIIN + "/ проживающий по адресу: "
                + doc.CustomerTheActualAddress + ". ПРОДАТЬ принадлежащему мне на основании Свидетельство о регистрации ТС, выдано "
                + doc.Subject.VehiclePassportIssued + ", от "
                + doc.Subject.DateOfIssue + " года, MF № "
                + doc.Subject.VehiclePassportId + ", автомобилем марки "
                + doc.Subject.Mark + ", Выпуска "
                + doc.Subject.Release + " года. \n \n", new Font("Times New Roman", 12));

            
            var paragraphContentCenter = section.AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentCenter, ParagraphAlignment.Center, Underline.None);           
            paragraphContentCenter.AddFormattedText("Идентификационный  № "
                + doc.Subject.IdentificationNumber + ",\n Кузов № "
                + doc.Subject.CarBody + ",\n Шасси № "
                + doc.Subject.Chassis + ",\n Регистрационный номерной знак "
                + doc.Subject.RegistrationPlate + ".", new Font("Times New Roman", 12));

            var paragraphContentSecond = section.AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentSecond, ParagraphAlignment.Justify, Underline.None);
            paragraphContentSecond.AddFormattedText("\n для чего предоставляю быть моим представителем в органах УДП и во всех других государственных регистрирующих,"
                + " административных органах, следить за техническим состоянием автомашины, производить необходимый ремонт," 
                + " проходить технический осмотр, оплачивать необходимые налоги и сборы, получить дубликаты,"
                + " быть моим представителем в страховой компании и страховое выплаты, прохождении таможенных процедур и всех необходимых таможенных документов в органах таможенных организациях,"
                + " а также выезд за границу, подавать и подписывать от моего имени все необходимые заявления, заключать договора и представлять требуемые документы, заключать трудовые договоры,"
                + " в необходимых случаях расписываться за меня, подавать заявления и выполнять все действия, связанные с данным поручением, быть моим представителем в УДП ГАИ и снять с учета." 
                + " Доверенность выдана сроком на один год, без права передоверия. Доверенность прочитана нотариусом вслух. Смысл, значение и юридические последствия документа разъяснены и соответствуют моим намерениям."
                + " Содержание ст. 170 и 171 ГК.РК., и  ст. 34 Закон РК «О браке(супружестве и семьи» и ст. 18, п. 1, п.п. 2, Закона «О нотариате» доверителю нотариусом разъяснено. \n",
                new Font("Times New Roman", 12));

            paragraphContentSecond.AddFormattedText("\n ПОДПИСЬ:_______________________________________________________", new Font("Times New Roman", 14));
            paragraphContentSecond.AddFormattedText("\n 19 июля 2017 года. Настоящая доверенность удостоверена мной, "
                + DocumentGeneratorBase.LAWYER_FULL_NAME_BY_WHOM 
                + ", действующей на основании Государственный Лицензии № 0001727 от 06 декабря 2003 года, выданной Министерством Юстиции Республики Казахстан. \n"
                + " Доверенность подписана гр. Бесбаевой Саркыт Мерсалимкызы, ее полномочия, в моем присутствии проверена.Личность ее установлена, дееспособность  проверена.\n", new Font("Times New Roman", 12));

            // Первая таблица
            var table = section.AddTable();
            table.AddColumn("6.2cm");
            table.AddColumn("10cm");

            table.Style = "Table";
            //table.Borders.Width = 1.0;
            //table.Borders.Color = Colors.Black;
            table.BottomPadding = 5;
            table.Rows.LeftIndent = 0;

            paragraphContentSecond = table.AddRow().Cells[1].AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentSecond, ParagraphAlignment.Left, Underline.None);
            paragraphContentSecond.AddFormattedText("\n Зарегистрировано в реестре за № 2217. ", new Font("Times New Roman", 12));

            paragraphContentSecond = table.AddRow().Cells[1].AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentSecond, ParagraphAlignment.Left, Underline.None);
            paragraphContentSecond.AddFormattedText("Услуги нотариуса", new Font("Times New Roman", 12));

            // Вторая таблица 
            var table1 = section.AddTable();
            table1.AddColumn("5.4cm");
            table1.AddColumn("5.4cm");
            table1.AddColumn("5.4cm");

            table1.Style = "Table";
            //table1.Borders.Width = 1.0;
            //table1.Borders.Color = Colors.Black;
            table1.BottomPadding = 5;
            table1.TopPadding = 15;
            table1.Rows.LeftIndent = 0;

            var row = table1.AddRow();
            
            paragraphContentSecond = row.Cells[0].AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentSecond, ParagraphAlignment.Center, Underline.None);
            paragraphContentSecond.AddFormattedText("м.п.", new Font("Times New Roman", 16));

            paragraphContentSecond = row.Cells[1].AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentSecond, ParagraphAlignment.Center, Underline.None);
            paragraphContentSecond.AddFormattedText("Нотариус:", new Font("Times New Roman", 16));

            paragraphContentSecond = row.Cells[2].AddParagraph();
            DocumentGeneratorBase.Paragraph(paragraphContentSecond, ParagraphAlignment.Center, Underline.None);
            paragraphContentSecond.AddFormattedText(DocumentGeneratorBase.LAWYER_FULL_NAME_INITIAL, new Font("Times New Roman", 16));


            return document;
        }
    }
}
