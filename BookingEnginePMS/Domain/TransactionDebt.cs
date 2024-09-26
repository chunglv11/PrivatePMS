namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionDebt")]
    public partial class TransactionDebt
    {
        public int TransactionDebtId { get; set; }

        public int? ReservationDebtId { get; set; }

        public double? Pay { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(100)]
        public string UserChange { get; set; }
    }
}
