using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace document_generator.Models
{
    public class PowerOfAttorneyAutoSaleDocument
    {
        public string SellerFullName { get; set; }

        //public string SellerFirstName { get; set; } // Имя

        //public string SellerLastName { get; set; } // Фамилия

        //public string SellerMiddleName { get; set; } // Отчество

        public string SellerBirthDate { get; set; } // Дата рождения 07.01.1951

        public string SellerBirthPlace { get; set; } // Место рождения область

        public string SellerTheActualAddress { get; set; } // фактический адрес
        public string SellerIIN { get; set; }

        public string CustomerFullName { get; set; }

        //public string CustomerFirstName { get; set; } // Имя
    
        //public string CustomerLastName { get; set; } // Фамилия

        //public string CustomerMiddleName { get; set; } // Отчество

        public string CustomerBirthDate { get; set; } // Дата рождения 07.01.1951

        public string CustomerBirthPlace { get; set; } // Место рождения область

        public string CustomerTheActualAddress { get; set; } // фактический адрес
        public string CustomerIIN { get; set; }

        public SubjectOfThePowerOfAttorney Subject { get; set; } // 

    }

    //Предмет доверенности
    public class SubjectOfThePowerOfAttorney
    {
        public string VehiclePassportIssued { get; set; } // Паспорт транспортного средства / Cвидетельство о регистрации тс ГАИ УВД  ДВД
        public string VehiclePassportId { get; set; } // МF № 00061435
        public string DateOfIssue { get; set; } // дата выдачи

        public string Mark { get; set; } // марка машины BMW 520

        public string Release { get; set; } // год выпуска 
       

        public string IdentificationNumber { get; set; }

        public string CarBody { get; set; } // Кузов

        public string Chassis // Шасси автомобиля (ящик) номер, если номер Не Установлен то Н.У.
        {
            get;set;
            //get
            //{
            //    if (Chassis != null && Chassis != "")
            //        return Chassis;
            //    else
            //        return "Н.У.";

            //}
            //set
            //{
            //    Chassis = value;
            //}
        }

        public string RegistrationPlate { get; set; } // Регистрационный номерной знак  
    }

}
