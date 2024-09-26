namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int InvoiceId { get; set; }

        public int? HotelId { get; set; }

        [Required]
        [StringLength(500)]
        public string InvoiceCode { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public float? TotalAmount { get; set; }

        [StringLength(50)]
        public string CurrencyCode { get; set; }

        public DateTime? DateInvoice { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public int? Status { get; set; }

        public int? FeedBack { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        public bool? IsDelete { get; set; }

        [StringLength(200)]
        public string NameOnCard { get; set; }

        [StringLength(200)]
        public string CardNumber { get; set; }

        [StringLength(200)]
        public string SecurityCode { get; set; }

        public int? ExprireMonth { get; set; }

        public int? ExprireYear { get; set; }

        [StringLength(50)]
        public string UserCreate { get; set; }
    }
}
