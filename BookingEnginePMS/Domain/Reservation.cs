namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        public int ReservationId { get; set; }

        public int? HotelId { get; set; }

        public int? GuestId { get; set; }

        public int? CompanyId { get; set; }

        public int? TypeReservation { get; set; }

        [StringLength(200)]
        public string ReminiscentName { get; set; }

        [StringLength(100)]
        public string Color { get; set; }

        public int? Adult { get; set; }

        public int? Children { get; set; }

        [StringLength(100)]
        public string Voucher { get; set; }

        public int? BookingSource { get; set; }

        [StringLength(100)]
        public string ArrivalFlightDate { get; set; }

        [StringLength(100)]
        public string ArrivalFlightTime { get; set; }

        [StringLength(100)]
        public string DepartureFlightDate { get; set; }

        [StringLength(100)]
        public string DepartureFlightTime { get; set; }

        public DateTime? CheckIn { get; set; }

        public DateTime? CheckOut { get; set; }

        public int? PaymentType { get; set; }

        public double? Deposit { get; set; }

        public int? Status { get; set; }

        [StringLength(500)]
        public string NoteForBill { get; set; }

        public DateTime? CreateDate { get; set; }

        public double? ExcessCash { get; set; }
    }
}
