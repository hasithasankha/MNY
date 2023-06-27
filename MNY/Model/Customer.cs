using FluentValidation;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MNY.Model
{
    public class Customer
    {
        private Customer objCustomer;

        public Customer()
        {
        }

        public Customer(Customer objCustomer)
        {
            this.objCustomer = objCustomer;
        }

        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
