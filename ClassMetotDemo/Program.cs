using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer();
            CustomerManager manager = new CustomerManager();
            bool exitStatement = false;


            while (!exitStatement)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n 1: Müşteri ekleme \n 2: Müşteri silme \n 3: Müşteri listeleme \n 4: Çıkış");
                byte answer = Convert.ToByte(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Müşteri idsini giriniz: ");
                        newCustomer.Id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Müşteri ismini giriniz: ");
                        newCustomer.FirstName = Console.ReadLine();
                        Console.WriteLine("Müşteri soyadını giriniz: ");
                        newCustomer.LastName = Console.ReadLine();
                        Console.WriteLine("Müşteri Tc nosunu giriniz: ");
                        newCustomer.TcNumber = Console.ReadLine();

                        manager.AddCustomer(newCustomer);
                        break;
                    case 2:
                        Console.WriteLine("Lütfen silmek istediğinz müşterinin id sini giriniz: ");
                        int id = Convert.ToInt16(Console.ReadLine());
                        manager.DeleteCustomer(id);
                        break;
                    case 3:
                        manager.ListCustomer(manager.CreateCustomerList());
                        break;
                    case 4:
                        exitStatement = true;
                        break;
                    default:
                        Console.WriteLine("Hatalı numara girdiniz!");
                        break;
                }
            }
        }
    }
}
