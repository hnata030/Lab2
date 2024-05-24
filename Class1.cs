using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Lab2.Models
{
    public class DataBaseModel
    {
        public int ID { get; set; }

        [Display(Name = "Имя")]
        [DisplayName("Имя")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        [DisplayName("Адрес")]
        public string Address { get; set; }

        [Display(Name = "Дата рождения")]
        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Email")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Номер телефона")]
        [DisplayName("Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Количество вакансий")]
        [DisplayName("Количество вакансий")]
        public int VacancyCount { get; set; }
    }
}