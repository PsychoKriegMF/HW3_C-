using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_C_
{
    public class Shop
    {
        public Shop() { }
        public string name_ { get; set; }
        public string descrition_ { get; set; }
        public string phone_ { get; set; }
        public string email_ { get; set; }
        public string Name() { return name_; }
        public string Description() { return descrition_; }
        public string Phone() { return phone_; }
        public string Email() { return email_; }

        public void Print()
        {
            Console.WriteLine($"Название магазина:{name_}\nОписание {descrition_}\n" +
                $"email{email_}Телефон{phone_}");
        }
    }
}
