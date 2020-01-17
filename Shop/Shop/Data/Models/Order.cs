using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Неверно введенные данные")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(20)]
        [Required(ErrorMessage = "Неверно введенные данные")]
        public string surname { get; set; }

        [Display(Name = "Ваш адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Неверно введенные данные")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Неверно введенные данные")]
        public string phone { get; set; }

        [Display(Name = "Електронный адрес")]
        [StringLength(40)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Неверно введенные данные")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; } 
    }
}
