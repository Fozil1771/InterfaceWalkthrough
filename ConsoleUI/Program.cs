using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if(prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} dowloads left. ");
                }
            }

            

            Console.ReadLine();
            
        }

        

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Fozil",
                LastName = "Zayn",
                City = "Namangan",
                EmailAddress = "fozil@gmail.com",
                PhoneNumber = "99890553"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new DigitalProductModel { Title = "Content of Program" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Interface code" });
            output.Add(new CourseProductModel { Title = ".Net Core Start to Finish" });

            return output;
        }
    }
}
