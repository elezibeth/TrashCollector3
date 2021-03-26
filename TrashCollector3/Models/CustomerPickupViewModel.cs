using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

using TrashCollector3;

namespace TrashCollector3.Models
{
    public class CustomerPickupViewModel
    {
        [Key]
        public int Id { get; set; }
        
        public List<Employee> Employees { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
