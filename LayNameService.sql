SELECT
    r.ReservationId,
    b.BookingId,
    b.ReservationId AS booking_IDreservation,
    bs.BookingServiceId,
    bs.ServiceId,
    sl.ServiceLanguageId,
	sl.ServiceName
FROM
    reservation r
JOIN
    booking b ON r.ReservationId = b.ReservationId
JOIN
    Bookingservice bs ON b.BookingId = bs.BookingId
JOIN
    servicelanguage sl ON bs.ServiceId = sl.ServiceId
where r.ReservationId = 69762;