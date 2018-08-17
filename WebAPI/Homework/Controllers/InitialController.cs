using Homework.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class InitialController : ApiController
    {
        // GET: Api

        static List<CustomerModel> customers = new List<CustomerModel>
        {
            new CustomerModel
            {
                Id = 2,
                Firstname = "Ivan",
                Lastname = "Petrov",
                PhoneNumber = "0891234865",
                SecondPhoneNumber = "0286345",
                Address = "ul. Momina salza 15"
            },
            new CustomerModel
            {
                Id= 4,
                Firstname = "Simona",
                Lastname = "Dimitrova",
                PhoneNumber = "0886345912",
                SecondPhoneNumber = "0234568",
                Address = "ul. Shipchenska"
            },
            new CustomerModel
            {
                Id= 8,
                Firstname = "Hristo",
                Lastname = "Antonov",
                PhoneNumber = "0886652315",
                SecondPhoneNumber = "0233225",
                Address = "ul. Sveta gora"
            }
        };

        public CustomerModel Get(int id)
        {
            var customerWanted = customers.Find(x => x.Id == id);

            return customerWanted; 
            
        }
    }
}