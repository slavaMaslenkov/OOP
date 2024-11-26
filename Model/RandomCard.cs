using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// Класс для получения случайных изданий.
    /// </summary>
    public class RandomCard : CardFactoryBase
    {
        /// <summary>
        /// Метод для получения случайного экземпляра издания.
        /// </summary>
        /// <param name="cardType">Тип издания.</param>
        /// <returns>Экземпляр случайного издания.</returns>
        /// <exception cref="ArgumentException">Типа издания
        /// не существует.</exception>
        public override CardBase GetInstance(CardType cardType)
        {
            const int minYear = 1;
            const int maxYear = 2024;
            const int startPage = 20;
            const int endPage = 40;

            var year = GetRandomValue(minYear, maxYear);
            
            string[] namesArray =
            {
                "Вячеслав", "Эдуард", "Руслан", "Евгений"
            };

            string[] surnamesArray =
            {
                "Кочин", "Салихов", "Богданов", "Разин"
            };

            string[] patronymicsArray =
            {
                "Эдуардович", "Вячеславович", "Русланович", "Юрьевич"
            };

            string[] titlesArray =
            {
                "Война и мир",
                "На маяк",
                "Звук и ярость",
                "Распад",
                "Уловка-22",
                "Дети полуночи",
                "О дивный новый мир"
            };

            string[] placeOfPublicationArray =
            {
                "Москва","Томск","Воронеж","Пятигорск"
            };

            string[] publishingHouseArray =
            {
                "ТПУ","ТУСУР","МГУ","Феникс"
            };

            switch (cardType)
            {
                case (CardType.Book):
                    {
                        string[] additionalInformationArray =
                        {
                            "учебное пособие","энциклопедия","эпическая поэма",
                            "роман", "справочник", "биография"
                        };

                        var sheet = GetRandomValue(1, endPage);
                        var name = GetRandomString(namesArray);
                        var surname = GetRandomString(surnamesArray);
                        var patronymic = GetRandomString(patronymicsArray);
                        var title = GetRandomString(titlesArray);
                        var additionalInformation 
                            = GetRandomString(additionalInformationArray);
                        var placeOfPublication 
                            = GetRandomString(placeOfPublicationArray);
                        var publishingHouse 
                            = GetRandomString(publishingHouseArray);

                        return new Book
                            (surname, name, patronymic, title,
                            placeOfPublication, publishingHouse, 
                            additionalInformation, year, sheet);
                    }

                case (CardType.Sbornik):
                    {
                        string[] namesOfSbornikArray =
                        {
                            "Международная конференция",
                            "Конференция им. Ясникова"
                        };

                        var name = GetRandomString(namesArray);
                        var surname = GetRandomString(surnamesArray);
                        var patronymic = GetRandomString(patronymicsArray);
                        var title = GetRandomString(titlesArray);
                        var nameOfSbornik
                            = GetRandomString(namesOfSbornikArray);
                        var placeOfPublication
                            = GetRandomString(placeOfPublicationArray);
                        var publishingHouse
                            = GetRandomString(publishingHouseArray);
                        var startSheet = GetRandomValue(1, startPage);
                        var endSheet = GetRandomValue(21, endPage);

                        return new Sbornik
                            (surname, name, patronymic, title,
                            nameOfSbornik, placeOfPublication, publishingHouse,
                            year, startSheet, endSheet);
                    }

                case (CardType.Dissertation):
                    {
                        string[] kindOfDissertArray =
                        {
                            "кандидатской степени",
                            "магистерской степени",
                            "докторской степни"
                        };

                        string[] specialtyCodeArray =
                        {
                            "13.00.01",
                            "13.04.02",
                            "09.04.03"
                        };

                        string[] organizationsArray =
                        {
                            "ТПУ","ТУСУР","ТГУ","СФУ",
                        };

                        string[] branchOfScienceArray =
                        {
                            "мед.наук","фил. наук","тех.наук",
                        };

                        string[] nameOfSpecialityArray =
                        {
                            "Общая педагогика","Электроэнергетика",
                            "Прикладная информатика"
                        };

                        string[] cityArray =
                        {
                           "Москва","Томск","Воронеж","Пятигорск"
                        };

                        var sheet = GetRandomValue(1, endPage);
                        var name = GetRandomString(namesArray);
                        var surname = GetRandomString(surnamesArray);
                        var patronymic = GetRandomString(patronymicsArray);
                        var title = GetRandomString(titlesArray);
                        var kindOfDissert
                            = GetRandomString(kindOfDissertArray);
                        var specialtyCode
                            = GetRandomString(specialtyCodeArray);
                        var organizations
                            = GetRandomString(organizationsArray);
                        var branchOfScience
                        = GetRandomString(branchOfScienceArray);
                        var nameOfSpeciality
                        = GetRandomString(nameOfSpecialityArray);
                        var city
                            = GetRandomString(cityArray);

                        return new Dissertation
                            (surname, name, patronymic, title,
                            kindOfDissert, city, branchOfScience,
                            specialtyCode, organizations, nameOfSpeciality, 
                            year, sheet);
                    }

                case (CardType.Magazine):
                    {
                        string[] nameOfMagazineArray =
                        {
                            "Животные Африки",
                            "IEEE"
                        };

                        var name = GetRandomString(namesArray);
                        var surname = GetRandomString(surnamesArray);
                        var patronymic = GetRandomString(patronymicsArray);
                        var title = GetRandomString(titlesArray);
                        var nameOfMagazine
                            = GetRandomString(nameOfMagazineArray);
                        var placeOfPublication
                            = GetRandomString(placeOfPublicationArray);
                        var publishingHouse
                            = GetRandomString(publishingHouseArray);
                        var startSheet = GetRandomValue(1, startPage);
                        var endSheet = GetRandomValue(21, endPage);
                        var numberOfMagazine = GetRandomDigit(1, startPage);
                        return new Magazine
                            (surname, name, patronymic, title,
                            nameOfMagazine, numberOfMagazine,
                            year, startSheet, endSheet);
                    }

                default:
                    throw new ArgumentException
                        ("Неизвестный тип издания.");
            }
        }
    }
}
