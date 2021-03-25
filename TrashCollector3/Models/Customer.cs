using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        [Display(Name = "Customer ID")]
        public IdentityUser IdentityUser { get; set; }



        //bill
        [Display(Name = "Your Bill In Real Time")]
        public double AmountOwed { get; set; }

        //Address
        [Display(Name = "Address Number")]
        public int Number { get; set; }

        [Display(Name = "Street")]
        public string StreetName { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip")]
        public int ZipCode { get; set; }


        //pause service
        [Display(Name = "Pause Service Start and End Dates")]
        [DataType(DataType.Duration)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //one time pickup
        [Display(Name = "One Time Pickup")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int Date { get; set; }
        public int Time { get; set; }

        // regular pickup day

        [Display(Name = "Type in the day of the week as Monday, Tuesday, Wednesday, Thursday, or Friday. Service not available on weekends.")]
        public string Day { get; set; }
    }
}
