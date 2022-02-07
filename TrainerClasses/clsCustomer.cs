using System;

namespace TrainerClasses
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}