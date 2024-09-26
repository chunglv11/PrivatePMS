USE [WebCongTy_pmasikyLC]
GO
/****** Object:  StoredProcedure [dbo].[Reservation_Get_ForInvoice]    Script Date: 8/21/2024 9:18:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reservation_Get_Service]
@ReservationId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
    sl.ServiceName
FROM
    reservation r
JOIN
    booking b ON r.ReservationId = b.ReservationId
JOIN
    Bookingservice bs ON b.BookingId = bs.BookingId
JOIN
    servicelanguage sl ON bs.ServiceId = sl.ServiceId
WHERE
    r.ReservationId = 69762;

END