using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_C_
{
    public class Journal
    {
        public Journal() { }
        public string name_ { get; set; }
        public string dateTime_ { get; set; }
        public string description_ { get; set; }
        public string phone_ { get; set; }
        public string email_ { get; set; }
        public string Name() { return name_; }
        public string DateTime() { return dateTime_; }
        public string Description() { return description_; }
        public string Phone() { return phone_; }
        public string Email() { return email_; }

        public void Print()
        {
            Console.WriteLine($"Название магазина:{name_}\nДата основания {dateTime_}\nОписание {description_}\n" +
                $"email{email_}\n Телефон{phone_}");
        }
    }
}
