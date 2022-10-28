using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Alper Buğra";
            customer1.LastName = "Polat";
            customer1.CustomerNumber = "12345";
            customer1.TcNo = "1111111111";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";



            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
