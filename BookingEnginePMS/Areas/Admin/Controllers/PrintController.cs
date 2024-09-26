using BookingEnginePMS.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Windows.Media.Media3D;

namespace BookingEnginePMS.Areas.Admin.Controllers
{
    public class PrintController : SercurityController
    {
        // GET: Admin/Print
        /// <summary>
        /// screen confirm room
        /// </summary>
        /// <param name="id">bookingId</param>
        /// <returns></returns>
        public ActionResult ConfirmRoom(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                float taxFees = 0;
                using (var multi = connection.QueryMultiple("Booking_Get_Detail",
                    new
                    {
                        BookingId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    Booking booking = multi.Read<Booking>().SingleOrDefault();
                    List<BookingPrice> bookingPrices = multi.Read<BookingPrice>().ToList();
                    List<BookingExtrabed> bookingExtrabeds = multi.Read<BookingExtrabed>().ToList();
                    List<BookingService> bookingServices = multi.Read<BookingService>().ToList();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    VisaBooking visaBooking = multi.Read<VisaBooking>().SingleOrDefault();
                    List<InvoiceBooking> invoiceBookings = multi.Read<InvoiceBooking>().ToList();
                    string RoomCode = multi.Read<string>().SingleOrDefault();
                    List<BookingExtrabed> extrabeds = multi.Read<BookingExtrabed>().ToList();
                    CardBooking cardBooking = multi.Read<CardBooking>().SingleOrDefault();
                    ///////////////////
                    if (cardBooking is null) cardBooking = new CardBooking();
                    if (booking is null) booking = new Booking();
                    if (bookingPrices is null) bookingPrices = new List<BookingPrice>();
                    if (bookingExtrabeds is null) bookingExtrabeds = new List<BookingExtrabed>();
                    if (bookingServices is null) bookingServices = new List<BookingService>();
                    if (guest is null) guest = new Guest();
                    if (visaBooking is null) visaBooking = new VisaBooking();
                    if (invoiceBookings is null) invoiceBookings = new List<InvoiceBooking>();
                    if (RoomCode is null) RoomCode = "";
                    if (extrabeds is null) extrabeds = new List<BookingExtrabed>();

                    if (booking.IncludeVATAndServiceCharge)
                    {
                        taxFees = connection.QuerySingleOrDefault<float>("TaxFee_GetTotal_Lastest",
                               new
                               {
                                   HotelId = HotelId
                               },
                               commandType: CommandType.StoredProcedure);
                    }

                    booking.CardBooking = cardBooking;
                    guest.GuestId = booking.GuestId;
                    booking.RoomCode = RoomCode;
                    booking.Guest = guest;
                    booking.BookingPrices = bookingPrices;
                    booking.BookingExtrabeds = bookingExtrabeds;
                    booking.BookingServices = bookingServices;
                    booking.VisaBookings = visaBooking;
                    booking.InvoiceBookings = invoiceBookings;
                    float TotalRoomCharges = bookingPrices.Sum(x => x.Price);
                    float TotalServices = bookingServices.Sum(x => x.Price * x.Number);
                    float TotalExtrabed = bookingExtrabeds.Sum(x => x.Price * x.Number);
                    float DiscountForGuest = (TotalRoomCharges + TotalServices + TotalExtrabed) * booking.Discount / 100;
                    float TotalFees = (TotalRoomCharges + TotalServices + TotalExtrabed - DiscountForGuest) * taxFees / 100;
                    ViewData["hotel"] = hotel;
                    ViewData["booking"] = booking;
                    ViewData["TotalRoomCharges"] = TotalRoomCharges;
                    ViewData["TotalFees"] = TotalFees;
                    ViewData["TotalServices"] = TotalServices;
                    ViewData["TotalExtrabed"] = TotalExtrabed;
                    ViewData["Extrabeds"] = extrabeds;
                    ViewData["DiscountForGuest"] = DiscountForGuest;
                }
                return View();
            }
        }
        public ActionResult Invoide(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                float taxFees = 0;
                using (var multi = connection.QueryMultiple("Booking_Get_Detail",
                    new
                    {
                        BookingId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    Booking booking = multi.Read<Booking>().SingleOrDefault();
                    List<BookingPrice> bookingPrices = multi.Read<BookingPrice>().ToList();
                    List<BookingExtrabed> bookingExtrabeds = multi.Read<BookingExtrabed>().ToList();
                    List<BookingService> bookingServices = multi.Read<BookingService>().ToList();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    VisaBooking visaBooking = multi.Read<VisaBooking>().SingleOrDefault();
                    List<InvoiceBooking> invoiceBookings = multi.Read<InvoiceBooking>().ToList();
                    string RoomCode = multi.Read<string>().SingleOrDefault();
                    List<BookingExtrabed> extrabeds = multi.Read<BookingExtrabed>().ToList();
                    CardBooking cardBooking = multi.Read<CardBooking>().SingleOrDefault();
                    ///////////////////
                    if (cardBooking is null) cardBooking = new CardBooking();
                    if (booking is null) booking = new Booking();
                    if (bookingPrices is null) bookingPrices = new List<BookingPrice>();
                    if (bookingExtrabeds is null) bookingExtrabeds = new List<BookingExtrabed>();
                    if (bookingServices is null) bookingServices = new List<BookingService>();
                    if (guest is null) guest = new Guest();
                    if (visaBooking is null) visaBooking = new VisaBooking();
                    if (invoiceBookings is null) invoiceBookings = new List<InvoiceBooking>();
                    if (RoomCode is null) RoomCode = "";
                    if (extrabeds is null) extrabeds = new List<BookingExtrabed>();

                    if (booking.IncludeVATAndServiceCharge)
                    {
                        taxFees = connection.QuerySingleOrDefault<float>("TaxFee_GetTotal_Lastest",
                               new
                               {
                                   HotelId = HotelId
                               },
                               commandType: CommandType.StoredProcedure);
                    }
                    booking.CardBooking = cardBooking;
                    guest.GuestId = booking.GuestId;
                    booking.RoomCode = RoomCode;
                    booking.Guest = guest;
                    booking.BookingPrices = bookingPrices;
                    booking.BookingExtrabeds = bookingExtrabeds;
                    booking.BookingServices = bookingServices;
                    booking.VisaBookings = visaBooking;
                    booking.InvoiceBookings = invoiceBookings;
                    float TotalRoomCharges = bookingPrices.Sum(x => x.Price);
                    float TotalServices = bookingServices.Sum(x => x.Price * x.Number);
                    float TotalExtrabed = bookingExtrabeds.Sum(x => x.Price * x.Number);
                    float DiscountForGuest = (TotalRoomCharges + TotalServices + TotalExtrabed) * booking.Discount / 100;
                    float TotalFees = (TotalRoomCharges + TotalServices + TotalExtrabed - DiscountForGuest) * taxFees / 100;
                    ViewData["hotel"] = hotel;
                    ViewData["booking"] = booking;
                    ViewData["TotalRoomCharges"] = TotalRoomCharges;
                    ViewData["TotalFees"] = TotalFees;
                    ViewData["TotalServices"] = TotalServices;
                    ViewData["TotalExtrabed"] = TotalExtrabed;
                    ViewData["Extrabeds"] = extrabeds;
                    ViewData["DiscountForGuest"] = DiscountForGuest;
                }
                return View();
            }
        }
        public ActionResult RoomCharges(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                float taxFees = 0;
                using (var multi = connection.QueryMultiple("Booking_Get_Detail",
                    new
                    {
                        BookingId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    Booking booking = multi.Read<Booking>().SingleOrDefault();
                    List<BookingPrice> bookingPrices = multi.Read<BookingPrice>().ToList();
                    List<BookingExtrabed> bookingExtrabeds = multi.Read<BookingExtrabed>().ToList();
                    List<BookingService> bookingServices = multi.Read<BookingService>().ToList();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    VisaBooking visaBooking = multi.Read<VisaBooking>().SingleOrDefault();
                    List<InvoiceBooking> invoiceBookings = multi.Read<InvoiceBooking>().ToList();
                    string RoomCode = multi.Read<string>().SingleOrDefault();
                    List<BookingExtrabed> extrabeds = multi.Read<BookingExtrabed>().ToList();
                    CardBooking cardBooking = multi.Read<CardBooking>().SingleOrDefault();
                    ///////////////////
                    if (booking is null) booking = new Booking();
                    if (guest is null) guest = new Guest();
                    if (RoomCode is null) RoomCode = "";
                    if (extrabeds is null) extrabeds = new List<BookingExtrabed>();

                    if (booking.IncludeVATAndServiceCharge)
                    {
                        taxFees = connection.QuerySingleOrDefault<float>("TaxFee_GetTotal_Lastest",
                               new
                               {
                                   HotelId = HotelId
                               },
                               commandType: CommandType.StoredProcedure);
                    }
                    booking.RoomCode = RoomCode;
                    booking.Guest = guest;
                    float TotalRoomCharges = bookingPrices.Sum(x => x.Price);
                    float DiscountForGuest = (TotalRoomCharges) * booking.Discount / 100;
                    float TotalFees = (TotalRoomCharges - DiscountForGuest) * taxFees / 100;
                    ViewData["hotel"] = hotel;
                    ViewData["booking"] = booking;
                    ViewData["TotalRoomCharges"] = TotalRoomCharges;
                    ViewData["TotalFees"] = TotalFees;
                    ViewData["DiscountForGuest"] = DiscountForGuest;
                }
                return View();
            }
        }
        public ActionResult ExtrabedCharges(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                float taxFees = 0;
                using (var multi = connection.QueryMultiple("Booking_Get_Detail",
                    new
                    {
                        BookingId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    Booking booking = multi.Read<Booking>().SingleOrDefault();
                    List<BookingPrice> bookingPrices = multi.Read<BookingPrice>().ToList();
                    List<BookingExtrabed> bookingExtrabeds = multi.Read<BookingExtrabed>().ToList();
                    List<BookingService> bookingServices = multi.Read<BookingService>().ToList();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    VisaBooking visaBooking = multi.Read<VisaBooking>().SingleOrDefault();
                    List<InvoiceBooking> invoiceBookings = multi.Read<InvoiceBooking>().ToList();
                    string RoomCode = multi.Read<string>().SingleOrDefault();
                    List<BookingExtrabed> extrabeds = multi.Read<BookingExtrabed>().ToList();
                    CardBooking cardBooking = multi.Read<CardBooking>().SingleOrDefault();
                    ///////////////////
                    if (cardBooking is null) cardBooking = new CardBooking();
                    if (booking is null) booking = new Booking();
                    if (bookingExtrabeds is null) bookingExtrabeds = new List<BookingExtrabed>();
                    if (guest is null) guest = new Guest();
                    if (RoomCode is null) RoomCode = "";
                    if (extrabeds is null) extrabeds = new List<BookingExtrabed>();

                    if (booking.IncludeVATAndServiceCharge)
                    {
                        taxFees = connection.QuerySingleOrDefault<float>("TaxFee_GetTotal_Lastest",
                               new
                               {
                                   HotelId = HotelId
                               },
                               commandType: CommandType.StoredProcedure);
                    }
                    booking.RoomCode = RoomCode;
                    booking.Guest = guest;
                    booking.BookingExtrabeds = bookingExtrabeds;
                    float TotalExtrabed = bookingExtrabeds.Sum(x => x.Price * x.Number);
                    float DiscountForGuest = (TotalExtrabed) * booking.Discount / 100;
                    float TotalFees = (TotalExtrabed - DiscountForGuest) * taxFees / 100;
                    ViewData["hotel"] = hotel;
                    ViewData["booking"] = booking;
                    ViewData["TotalExtrabed"] = TotalExtrabed;
                    ViewData["Extrabeds"] = extrabeds;
                    ViewData["TotalFees"] = TotalFees;
                    ViewData["DiscountForGuest"] = DiscountForGuest;
                }
                return View();
            }
        }
        public ActionResult ServicesCharges(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                float taxFees = 0;
                using (var multi = connection.QueryMultiple("Booking_Get_Detail",
                    new
                    {
                        BookingId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    Booking booking = multi.Read<Booking>().SingleOrDefault();
                    List<BookingPrice> bookingPrices = multi.Read<BookingPrice>().ToList();
                    List<BookingExtrabed> bookingExtrabeds = multi.Read<BookingExtrabed>().ToList();
                    List<BookingService> bookingServices = multi.Read<BookingService>().ToList();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    VisaBooking visaBooking = multi.Read<VisaBooking>().SingleOrDefault();
                    List<InvoiceBooking> invoiceBookings = multi.Read<InvoiceBooking>().ToList();
                    string RoomCode = multi.Read<string>().SingleOrDefault();
                    List<BookingExtrabed> extrabeds = multi.Read<BookingExtrabed>().ToList();
                    CardBooking cardBooking = multi.Read<CardBooking>().SingleOrDefault();
                    ///////////////////
                    if (booking is null) booking = new Booking();
                    if (bookingServices is null) bookingServices = new List<BookingService>();
                    if (guest is null) guest = new Guest();
                    if (RoomCode is null) RoomCode = "";

                    if (booking.IncludeVATAndServiceCharge)
                    {
                        taxFees = connection.QuerySingleOrDefault<float>("TaxFee_GetTotal_Lastest",
                               new
                               {
                                   HotelId = HotelId
                               },
                               commandType: CommandType.StoredProcedure);
                    }
                    booking.RoomCode = RoomCode;
                    booking.Guest = guest;
                    booking.BookingServices = bookingServices;
                    float TotalServices = bookingServices.Sum(x => x.Price * x.Number);
                    float DiscountForGuest = (TotalServices) * booking.Discount / 100;
                    float TotalFees = (TotalServices - DiscountForGuest) * taxFees / 100;
                    ViewData["hotel"] = hotel;
                    ViewData["booking"] = booking;
                    ViewData["TotalServices"] = TotalServices;
                    ViewData["TotalFees"] = TotalFees;
                    ViewData["DiscountForGuest"] = DiscountForGuest;
                }
                return View();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">reservationId</param>
        /// <returns></returns>
        public ActionResult InvoiceReservaton(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                using (var multi = connection.QueryMultiple("Reservation_Get_ForInvoice",
                    new
                    {
                        ReservationId = id
                    }, commandType: CommandType.StoredProcedure))
                {
                    Reservation reservation = multi.Read<Reservation>().SingleOrDefault();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    string CompanyName = multi.Read<string>().SingleOrDefault();
                    if (reservation is null) reservation = new Reservation();
                    if (guest is null) guest = new Guest();
                    ViewData["guest"] = guest;
                    ViewData["reservation"] = reservation;
                    ViewData["CompanyName"] = CompanyName;
                }
                //20-8-24 thêm lấy chi chú tổng
                using (var multi = connection.QueryMultiple("Reservation_Get_Note",
                    new
                    {
                        ReservationId = id,
                    }, commandType: CommandType.StoredProcedure))
                {
                    var reservationNote = multi.Read<ReservationNote>().ToList();
                    ViewData["Note"] = reservationNote;
                }
                //21-8-24 lấy thông tin về dịch vụ
                //22-8-24 thêm lấy thông tin về giường
                using (var multi = connection.QueryMultiple("Reservation_Get_Service",
                    new
                    {
                        ReservationId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    var NameService = multi.Read<BookingService_Resrvation>().ToList();
                    ViewData["NameService"] = NameService;
                }
                List<Booking_Reservation> bookings = connection.Query<Booking_Reservation>("Reservation_Get_Booking",
                    new
                    {
                        ReservationId = id,
                        Status = -1
                    }, commandType: CommandType.StoredProcedure).ToList();
                //13-9 sửa lại lấy thuế và phí dvu
                string taxFees = connection.QuerySingleOrDefault<string>("TaxFee_GetTotal_Lastest",
                    new
                    {
                        HotelId = HotelId
                    },
                    commandType: CommandType.StoredProcedure);
                // Phân tích giá trị thuế từ chuỗi
                float vat = 0.0f;
                float feeService = 0.0f;
                if (!string.IsNullOrEmpty(taxFees))
                {
                    // Phân tích chuỗi thành hai giá trị
                    string[] taxFeesArray = taxFees.Split(',');

                    if (taxFeesArray.Length > 0)
                    {
                        float.TryParse(taxFeesArray[0], out vat);
                    }
                    if (taxFeesArray.Length > 1)
                    {
                        float.TryParse(taxFeesArray[1], out feeService);
                    }
                }
                float TotalFees = 0;
                if (bookings is null)
                    bookings = new List<Booking_Reservation>();
                bookings.ForEach(x =>
                {
                    float taxFeesForBooking = 0;
                    float taxfeeServiceForBooking = 0;
                    using (var multi = connection.QueryMultiple("Booking_Get_Multi_Price",
                        new
                        {
                            BookingId = x.BookingId
                        }, commandType: CommandType.StoredProcedure))
                    {
                        bool includeTaxFee = multi.Read<bool>().SingleOrDefault();
                        x.TotalRoom = multi.Read<float>().SingleOrDefault();
                        // 13/06/2024 đón dữ liệu bị lệch => thêm biến priceForDay để nhận dữ liệu 
                        float priceForDay = multi.Read<float>().SingleOrDefault();
                        x.TotalExtrabed = multi.Read<float>().SingleOrDefault();
                        x.TotalService = multi.Read<float>().SingleOrDefault();
                        if (includeTaxFee)
                            taxFeesForBooking = vat;
                            taxfeeServiceForBooking = feeService;
                        ViewBag.taxFees = taxFeesForBooking;
                        ViewBag.feeService = feeService;
                        float totalAmount = (x.TotalRoom + x.TotalExtrabed + x.TotalService) * (1 - x.Discount / 100.0f) * (1 + taxFeesForBooking / 100.0f) * (1 + taxfeeServiceForBooking / 100.0f);
                        var total = (x.TotalRoom + x.TotalExtrabed + x.TotalService) * (100 - x.Discount);            
                        //mới, thêm totalfee
                        x.TotalFee = total * (taxfeeServiceForBooking + taxFeesForBooking + taxfeeServiceForBooking * taxFeesForBooking / 100) / 10000;
                        ViewBag.total = TotalFees;
                        x.Total = (float)Math.Round(totalAmount, 0);
                        //x.Total = (float)Math.Round((x.TotalRoom + x.TotalExtrabed + x.TotalService) * (100 - x.Discount) * (100 + taxFeesForBooking) / 10000, 0);
                        //Sửa bỏ cộng tiền dịch vụ(21/8/24)
                        //x.Total = (float)Math.Round((x.TotalRoom + x.TotalExtrabed) * (100 - x.Discount) * (100 + taxFeesForBooking) / 10000, 0);
                        
                    }
                });
                ViewData["hotel"] = hotel;
                ViewData["booking"] = bookings;
                return View();
            }
        }
        public ActionResult InvoiceReservatonDetail(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                using (var multi = connection.QueryMultiple("Reservation_Get_ForInvoice",
                    new
                    {
                        ReservationId = id
                    }, commandType: CommandType.StoredProcedure))
                {
                    Reservation reservation = multi.Read<Reservation>().SingleOrDefault();
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    string CompanyName = multi.Read<string>().SingleOrDefault();
                    if (reservation is null) reservation = new Reservation();
                    if (guest is null) guest = new Guest();
                    ViewData["guest"] = guest;
                    ViewData["reservation"] = reservation;
                    ViewData["CompanyName"] = CompanyName;
                }
                List<Booking_Reservation> bookings = connection.Query<Booking_Reservation>("Reservation_Get_Booking",
                    new
                    {
                        ReservationId = id,
                        Status = 3
                    }, commandType: CommandType.StoredProcedure).ToList();
                float taxFees = connection.QuerySingleOrDefault<float>("TaxFee_GetTotal_Lastest",
                    new
                    {
                        HotelId = HotelId
                    },
                    commandType: CommandType.StoredProcedure);
                if (bookings is null)
                    bookings = new List<Booking_Reservation>();
                bookings.ForEach(x =>
                {
                    using (var multi = connection.QueryMultiple("Booking_Get_AllTypePrice",
                        new
                        {
                            BookingId = x.BookingId
                        }, commandType: CommandType.StoredProcedure))
                    {
                        List<BookingPrice> bookingPrices = multi.Read<BookingPrice>().ToList();
                        List<BookingService> bookingServices = multi.Read<BookingService>().ToList();
                        List<BookingExtrabed> bookingExtrabeds = multi.Read<BookingExtrabed>().ToList();
                        if (bookingPrices is null) bookingPrices = new List<BookingPrice>();
                        if (bookingServices is null) bookingServices = new List<BookingService>();
                        if (bookingExtrabeds is null) bookingExtrabeds = new List<BookingExtrabed>();
                        x.BookingPrices = bookingPrices;
                        x.BookingServices = bookingServices;
                        x.BookingExtrabeds = bookingExtrabeds;
                    }
                    float taxFeesForBooking = 0;
                    using (var multi = connection.QueryMultiple("Booking_Get_Multi_Price",
                        new
                        {
                            BookingId = x.BookingId
                        }, commandType: CommandType.StoredProcedure))
                    {
                        bool includeTaxFee = multi.Read<bool>().SingleOrDefault();
                        x.TotalRoom = multi.Read<float>().SingleOrDefault();
                        // 15/06/2024 đón dữ liệu bị lệch => thêm biến priceForDay để nhận dữ liệu 
                        float priceForDay = multi.Read<float>().SingleOrDefault();
                        x.TotalExtrabed = multi.Read<float>().SingleOrDefault();
                        x.TotalService = multi.Read<float>().SingleOrDefault();
                        if (includeTaxFee)
                            taxFeesForBooking = taxFees;
                        x.Total = (float)Math.Round((x.TotalRoom + x.TotalExtrabed + x.TotalService) * (100 - x.Discount) * (100 + taxFeesForBooking) / 10000, 0);
                    }
                });
                ViewData["hotel"] = hotel;
                ViewData["booking"] = bookings;
                return View();
            }
        }
        public ActionResult Order(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");

            int HotelId = (int)Session["HotelId"];
            int LanguageId = (int)Session["LanguageId"];
            using (var connection = DB.ConnectionFactory())
            {
                Hotel hotel = connection.QuerySingleOrDefault<Hotel>("Hotel_Get_Detail_Single",
                    new
                    {
                        HotelId = HotelId,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure);
                using (var multi = connection.QueryMultiple("GuestOrder_Get_Print",
                    new
                    {
                        GuestOrderId = id,
                        LanguageId = LanguageId
                    }, commandType: CommandType.StoredProcedure))
                {
                    Guest guest = multi.Read<Guest>().SingleOrDefault();
                    GuestOrder guestOrder = multi.Read<GuestOrder>().SingleOrDefault();
                    List<GuestOrderService> guestOrderServices = multi.Read<GuestOrderService>().ToList();
                    if (guestOrder is null) guestOrder = new GuestOrder();
                    if (guestOrderServices is null) guestOrderServices = new List<GuestOrderService>();
                    float totalServices = guestOrderServices.Sum(x => x.Price * x.Number);
                    ViewData["hotel"] = hotel;
                    ViewData["guest"] = guest;
                    ViewData["guestOrder"] = guestOrder;
                    ViewData["guestOrderServices"] = guestOrderServices;
                    ViewData["totalServices"] = totalServices;
                }
                return View();
            }
        }

        // Email sent for Reservation
        public ActionResult EmailSent(int id)
        {
            if (!CheckSecurity())
                return Redirect("/Admin/Login/Index");
            using (var connection = DB.ConnectionFactory())
            {
                ReservationEmailSent reservationEmail = connection.QuerySingleOrDefault<ReservationEmailSent>("ReservationEmailSent_Detail",
                    new
                    {
                        ReservationEmailSentId = id
                    }, commandType: CommandType.StoredProcedure);
                ViewData["reservationEmail"] = reservationEmail;
                return View();
            }
        }
    }
}