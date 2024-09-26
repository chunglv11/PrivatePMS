namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisaBooking")]
    public partial class VisaBooking
    {
        public int VisaBookingId { get; set; }

        public int? BookingId { get; set; }

        [StringLength(200)]
        public string SerialNo { get; set; }

        [StringLength(200)]
        public string VisaNo { get; set; }

        [StringLength(100)]
        public string VisaDate { get; set; }

        [StringLength(200)]
        public string VisaIssuePlace { get; set; }

        [StringLength(200)]
        public string ArrivalFrom { get; set; }

        [StringLength(200)]
        public string ArrivalTrasportation { get; set; }

        [StringLength(100)]
        public string VisaExpiryDate { get; set; }

        [StringLength(100)]
        public string DateOfArrivalIn { get; set; }

        [StringLength(100)]
        public string TimeOfArrivalIn { get; set; }

        [StringLength(200)]
        public string PurposeOfVisit { get; set; }

        [StringLength(200)]
        public string GoingTo { get; set; }

        [StringLength(200)]
        public string DepartTransportation { get; set; }

        [StringLength(200)]
        public string ProposedDuration { get; set; }

        [StringLength(200)]
        public string VisaType { get; set; }
    }
}
