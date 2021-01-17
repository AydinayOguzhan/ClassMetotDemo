using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer musteri)
        {
            Console.WriteLine($"Müşteri eklendi! Eklenen bilgiler aşağıdaki gibidir: \n Id: {musteri.Id} \n İsim: {musteri.FirstName} \n Soy İsim: {musteri.LastName}" +
                $"\n Tc No: {musteri.TcNumber}");
        }

        public void DeleteCustomer(int customerId)
        {
            Console.WriteLine($"{customerId} id'li kullanıcı silindi.");
        }

        public void ListCustomer(Customer[] customerList)
        {
            foreach (var item in customerList)
            {
                Console.WriteLine($"Müşteri Id: {item.Id} \n Müşteri Adı: {item.FirstName} \n Müşteri Soyadı: {item.LastName} \n Müşteri Tc No: {item.TcNumber} " +
                    $"\n -------------------------------------------------");
            }
        }

        public Customer[] CreateCustomerList()
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Deneme isim 1";
            customer1.LastName = "Deneme soy isim 1";
            customer1.TcNumber = "1234567890";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Deneme isim 2";
            customer2.LastName = "Deneme soy isim 2";
            customer2.TcNumber = "0987654321";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Deneme isim 3";
            customer3.LastName = "Deneme soy isim 3";
            customer3.TcNumber = "1357902468";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Deneme isim 4";
            customer4.LastName = "Deneme soy isim 4";
            customer4.TcNumber = "2468013579";

            Customer[] customerList = new Customer[] { customer1, customer2, customer3, customer4 };

            return customerList;
        }
    }
}
