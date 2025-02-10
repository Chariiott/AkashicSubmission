using System;
using System.ComponentModel.DataAnnotations;
using Akashic8.Domain;

namespace Akashic8.Domain
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        // Billing Details
        //[Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Email is required.")]
        //[EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; } = string.Empty;

        //[Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = string.Empty;

        //[Required(ErrorMessage = "ZIP Code is required.")]
        //[RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid ZIP Code format.")]
        public string ZipCode { get; set; } = string.Empty;

        // Payment Details
        //[Required(ErrorMessage = "Cardholder Name is required.")]
        public string CardholderName { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Card Number is required.")]
        //[CreditCard(ErrorMessage = "Invalid card number.")]
        public string CardNumber { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Expiry Date is required.")]
        //[RegularExpression(@"^(0[1-9]|1[0-2])\/?([0-9]{2})$", ErrorMessage = "Expiry Date must be in MM/YY format.")]
        public string ExpiryDate { get; set; } = string.Empty;

        //[Required(ErrorMessage = "CVV is required.")]
        //[RegularExpression(@"^\d{3,4}$", ErrorMessage = "Invalid CVV format.")]
        public string CVV { get; set; } = string.Empty;

        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
