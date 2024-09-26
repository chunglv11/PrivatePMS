USE [WebCongTy_pmasikyLC]
GO
/****** Object:  StoredProcedure [dbo].[Reservation_Get_ForInvoice]    Script Date: 8/21/2024 9:18:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reservation_Get_Note]
@ReservationId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
    ReservationId,
    Note,
    CreateDate,
    UserName
	FROM dbo.ReservationNote
	WHERE ReservationId = @ReservationId;

END
