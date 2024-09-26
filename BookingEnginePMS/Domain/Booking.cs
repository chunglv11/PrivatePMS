namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingId { get; set; }

        public int? TypeBooking { get; set; }

        public int? ReservationId { get; set; }

        public int? RoomTypeId { get; set; }

        public int? RoomId { get; set; }

        public int? Adult { get; set; }

        public int? Children { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public DateTime? DepartureDate { get; set; }

        public int? GuestId { get; set; }

        public int? PaymentType { get; set; }

        public double? DepositPecent { get; set; }

        public double? DepositMonney { get; set; }

        public double? Discount { get; set; }

        public double? Prepaid { get; set; }

        public double? Paid { get; set; }

        public int? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? CheckinDate { get; set; }

        public DateTime? NoshowDate { get; set; }

        public DateTime? CheckoutDate { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? TransferDebtDate { get; set; }

        [StringLength(20)]
        public string UserCreate { get; set; }

        [StringLength(20)]
        public string UserCheckin { get; set; }

        [StringLength(20)]
        public string UserNoshow { get; set; }

        [StringLength(20)]
        public string UserCheckout { get; set; }

        [StringLength(20)]
        public string UserCancel { get; set; }

        [StringLength(20)]
        public string UserTransferDebt { get; set; }

        public bool? IsDebt { get; set; }

        public bool? EndPay { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [StringLength(50)]
        public string StayTime { get; set; }

        public bool? IncludeVATAndServiceCharge { get; set; }
    }
}
