using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookingEnginePMS.Domain
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<AmenityLanguage> AmenityLanguages { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingExtrabed> BookingExtrabeds { get; set; }
        public virtual DbSet<BookingPrice> BookingPrices { get; set; }
        public virtual DbSet<BookingService> BookingServices { get; set; }
        public virtual DbSet<CardBooking> CardBookings { get; set; }
        public virtual DbSet<CashDrawer> CashDrawers { get; set; }
        public virtual DbSet<CashHistory> CashHistories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConfigCurrency> ConfigCurrencies { get; set; }
        public virtual DbSet<ConfigEmail> ConfigEmails { get; set; }
        public virtual DbSet<ConfigOnePay> ConfigOnePays { get; set; }
        public virtual DbSet<ConfigPaymentMethod> ConfigPaymentMethods { get; set; }
        public virtual DbSet<ConfigPaymentMethodHotel> ConfigPaymentMethodHotels { get; set; }
        public virtual DbSet<ConfigPayPal> ConfigPayPals { get; set; }
        public virtual DbSet<ConfigTransfer> ConfigTransfers { get; set; }
        public virtual DbSet<ConfigViewBookingEngine> ConfigViewBookingEngines { get; set; }
        public virtual DbSet<ConfigVTCPay> ConfigVTCPays { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyUsed> CurrencyUseds { get; set; }
        public virtual DbSet<EmailAttachment> EmailAttachments { get; set; }
        public virtual DbSet<Extrabed> Extrabeds { get; set; }
        public virtual DbSet<ExtrabedLanguage> ExtrabedLanguages { get; set; }
        public virtual DbSet<Gallary> Gallaries { get; set; }
        public virtual DbSet<GroupGuest> GroupGuests { get; set; }
        public virtual DbSet<GroupHotel> GroupHotels { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<GuestOrder> GuestOrders { get; set; }
        public virtual DbSet<GuestOrderService> GuestOrderServices { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelLanguage> HotelLanguages { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceBooking> InvoiceBookings { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<note> notes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationSystemLanguage> NotificationSystemLanguages { get; set; }
        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<PlaneRate> PlaneRates { get; set; }
        public virtual DbSet<PlaneRateLanguage> PlaneRateLanguages { get; set; }
        public virtual DbSet<PlaneRateRoomType> PlaneRateRoomTypes { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<PolicyLanguage> PolicyLanguages { get; set; }
        public virtual DbSet<PolicyPaymentMethod> PolicyPaymentMethods { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionLanguage> PromotionLanguages { get; set; }
        public virtual DbSet<PromotionRoomType> PromotionRoomTypes { get; set; }
        public virtual DbSet<RateAvailability> RateAvailabilities { get; set; }
        public virtual DbSet<RenewalRegistration> RenewalRegistrations { get; set; }
        public virtual DbSet<RequestPassword> RequestPasswords { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationDebt> ReservationDebts { get; set; }
        public virtual DbSet<ReservationDeposit> ReservationDeposits { get; set; }
        public virtual DbSet<ReservationDepositBooking> ReservationDepositBookings { get; set; }
        public virtual DbSet<ReservationEmailSent> ReservationEmailSents { get; set; }
        public virtual DbSet<ReservationLogPayPal> ReservationLogPayPals { get; set; }
        public virtual DbSet<ReservationNote> ReservationNotes { get; set; }
        public virtual DbSet<ReservationService> ReservationServices { get; set; }
        public virtual DbSet<ReservationSource> ReservationSources { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<RoomTypeAmenity> RoomTypeAmenities { get; set; }
        public virtual DbSet<RoomTypeExtrabed> RoomTypeExtrabeds { get; set; }
        public virtual DbSet<RoomTypeGallery> RoomTypeGalleries { get; set; }
        public virtual DbSet<RoomTypeLanguage> RoomTypeLanguages { get; set; }
        public virtual DbSet<RoomTypePriceHour> RoomTypePriceHours { get; set; }
        public virtual DbSet<Screen> Screens { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
        public virtual DbSet<ServiceCategoryLanguage> ServiceCategoryLanguages { get; set; }
        public virtual DbSet<ServiceLanguage> ServiceLanguages { get; set; }
        public virtual DbSet<ServicePriceSchedule> ServicePriceSchedules { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<TaxFee> TaxFees { get; set; }
        public virtual DbSet<TaxFeeLanguage> TaxFeeLanguages { get; set; }
        public virtual DbSet<TemplateEmail> TemplateEmails { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<TransactionDebt> TransactionDebts { get; set; }
        public virtual DbSet<Transition> Transitions { get; set; }
        public virtual DbSet<TransitionLanguage> TransitionLanguages { get; set; }
        public virtual DbSet<TypeEmail> TypeEmails { get; set; }
        public virtual DbSet<TypeGuest> TypeGuests { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserChat> UserChats { get; set; }
        public virtual DbSet<UserChatMessage> UserChatMessages { get; set; }
        public virtual DbSet<UserHotel> UserHotels { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserNotification> UserNotifications { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<VisaBooking> VisaBookings { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<VoucherLanguage> VoucherLanguages { get; set; }
        public virtual DbSet<VoucherRoomType> VoucherRoomTypes { get; set; }
        public virtual DbSet<VoucherService> VoucherServices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.UserCheckin)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.UserNoshow)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.UserCheckout)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.UserCancel)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.UserTransferDebt)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.StayTime)
                .IsUnicode(false);

            modelBuilder.Entity<CardBooking>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<CardBooking>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CashDrawer>()
                .Property(e => e.LastOpenedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashHistory>()
                .Property(e => e.UserSession)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.CompanyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.ContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigCurrency>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigEmail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigEmail>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigEmail>()
                .Property(e => e.EmailReceive)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigOnePay>()
                .Property(e => e.MerchantId)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigOnePay>()
                .Property(e => e.AccessCode)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigOnePay>()
                .Property(e => e.Hashcode)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigOnePay>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigPayPal>()
                .Property(e => e.MerchantId)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTransfer>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTransfer>()
                .Property(e => e.NameOnCard)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigViewBookingEngine>()
                .Property(e => e.Lang)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigViewBookingEngine>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigVTCPay>()
                .Property(e => e.ReceiverAccount)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigVTCPay>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigVTCPay>()
                .Property(e => e.SecurityKey)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigVTCPay>()
                .Property(e => e.WebsiteId)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<CurrencyUsed>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<Extrabed>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Gallary>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<GroupHotel>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.ZIPCode)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.IdentityCart)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.CreditCard)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.DoIssueCreditCard)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.CVC)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.CreateBySource)
                .IsUnicode(false);

            modelBuilder.Entity<GuestOrder>()
                .Property(e => e.GuestOrderCode)
                .IsUnicode(false);

            modelBuilder.Entity<GuestOrder>()
                .Property(e => e.Cashier)
                .IsUnicode(false);

            modelBuilder.Entity<GuestOrder>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Hotline)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Skyper)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Google)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Youtobe)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SecurityCode)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceBooking>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.Ensign)
                .IsUnicode(false);

            modelBuilder.Entity<Notification>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<RequestPassword>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<RequestPassword>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<RequestPassword>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.Voucher)
                .IsUnicode(false);

            modelBuilder.Entity<ReservationEmailSent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ReservationEmailSent>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<ReservationNote>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomCode)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.RoomTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<RoomTypeGallery>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.ServiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceCategory>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceCategory>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<TemplateEmail>()
                .Property(e => e.CC)
                .IsUnicode(false);

            modelBuilder.Entity<TemplateEmail>()
                .Property(e => e.BCC)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDebt>()
                .Property(e => e.UserChange)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<UserChat>()
                .Property(e => e.FirstUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserChat>()
                .Property(e => e.SecondUser)
                .IsUnicode(false);

            modelBuilder.Entity<UserChatMessage>()
                .Property(e => e.UserSend)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.UserAgent)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Ip)
                .IsUnicode(false);

            modelBuilder.Entity<VisaBooking>()
                .Property(e => e.VisaDate)
                .IsUnicode(false);

            modelBuilder.Entity<VisaBooking>()
                .Property(e => e.VisaExpiryDate)
                .IsUnicode(false);

            modelBuilder.Entity<VisaBooking>()
                .Property(e => e.DateOfArrivalIn)
                .IsUnicode(false);

            modelBuilder.Entity<VisaBooking>()
                .Property(e => e.TimeOfArrivalIn)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.VoucherCode)
                .IsUnicode(false);
        }
    }
}
