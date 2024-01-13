using Grpc.Net.Client;
using GrpcCustomersService;
using Moldovan_Andrei_Lab1.Models;
using Microsoft.AspNetCore.Mvc;
namespace Moldovan_Andrei_Lab1.Controllers
{

    public class CustomersGrpcController : Controller
    {
        private readonly GrpcChannel channel;
        public CustomersGrpcController()
        {
            channel = GrpcChannel.ForAddress("https://localhost:5001");
        }
        [HttpGet]
        public IActionResult Index()
        {
            var client = new CustomerService.CustomerServiceClient(channel);
            CustomerList cust = client.GetAll(new Empty());
            return View(cust);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GrpcCustomersService.Customer customer)
        {
            if (ModelState.IsValid)
            {
                var client = new
               CustomerService.CustomerServiceClient(channel);
                var createdCustomer = client.Insert(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var client = new CustomerService.CustomerServiceClient(channel);
            Models.Customer existingCustomer = client.GetCustomer(new CustomerRequest { CustomerId = id });
            return View(existingCustomer);
        }

        [HttpPost]
        public IActionResult Edit(GrpcCustomersService.Customer customer)
        {
            if (ModelState.IsValid)
            {
                var client = new CustomerService.CustomerServiceClient(channel);
                var updatedCustomer = client.Update(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            var client = new CustomerService.CustomerServiceClient(channel);
            Models.Customer existingCustomer = client.GetCustomer(new CustomerRequest { CustomerId = id });
            return View(existingCustomer);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(string id)
        {
            var client = new CustomerService.CustomerServiceClient(channel);
            client.Delete(new CustomerRequest { CustomerId = id });
            return RedirectToAction(nameof(Index));
        }
    }
}