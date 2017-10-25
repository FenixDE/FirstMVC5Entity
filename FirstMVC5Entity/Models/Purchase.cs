using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC5Entity.Models
{
    public class Purchase //отвечаeт за отдельную совершаемую покупку книги
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // имя и фамилия покупателя
        public string Person { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        // ID книги
        public int BookId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}