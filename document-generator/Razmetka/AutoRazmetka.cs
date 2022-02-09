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
            paragraphContentSecond.AddFormattedText("\n для чего предоставляю быть моим представителем в органах УДП и во всех других государственных регистрирующих, административных органах, следить за техническим состоянием автомашины, производить необходимый ремонт, проходить технический осмотр, оплачивать необходимые налоги и сборы, получить дубликаты, быть моим представителем в страховой компании и страховое выплаты, прохождении таможенных процедур и всех необходимых таможенных документов в органах таможенных организациях, а также выезд за границу, подавать и подписывать от моего имени все необходимые заявления, заключать договора и представлять требуемые документы, заключать трудовые договоры, в необходимых случаях расписываться за меня, подавать заявления и выполнять все действия, связанные с данным поручением, быть моим представителем в УДП ГАИ и снять с учета." 
                + " Доверенность выдана сроком на один год, без права передоверия. Доверенность прочитана нотариусом вслух. Смысл, значение и юридические последствия документа разъяснены и соответствуют моим намерениям. Содержание ст. 170 и 171 ГК.РК., и  ст. 34 Закон РК «О браке(супружестве и семьи» и ст. 18, п. 1, п.п. 2, Закона «О нотариате» доверителю нотариусом разъяснено.",
                new Font("Times New Roman", 12));

            return document;
        }
    }
}
