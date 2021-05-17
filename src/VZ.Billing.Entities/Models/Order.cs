using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VZ.Billing.Entities.Enums;

namespace VZ.Billing.Entities.Models
{
    public class Order
    {
        [Range(1, int.MaxValue, ErrorMessage = "Order number should be bigger than 0")]
        public int Number { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Userid should be bigger than 0")]
        public int Userid { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "PayableAmount should be bigger than 0")]
        public decimal PayableAmount { get; set; }
        public PaymentGateway PaymentGateway { get; set; }
        public string Description { get; set; }
    }
}
