USE [Cyber_Cafe]
GO
/****** Object:  StoredProcedure [dbo].[MakeReservation]    Script Date: 12/21/2019 1:22:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[MakeReservation]
	-- Add the parameters for the stored procedure here
	@EID int,
	@Date date,
	@room_no int,
	@game_name varchar(20),
	@CID int,
	@start_time time,
	@end_time time
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF	EXISTS (SELECT * FROM Shift_Logs where Shift_Logs.ID = @EID and Shift_Logs.Date = @Date)
	BEGIN
		IF NOT EXISTS(SELECT * FROM Reserve WHERE [Date] = @DATE AND room_no = @room_no AND (@start_time >= start_time AND @start_time < end_time))
		BEGIN
			INSERT INTO Reserve VALUES(@EID, @Date, @room_no, @game_name, @CID, @start_time, @end_time)
			RETURN 1
		END
		ELSE RETURN -1
	END
	ELSE RETURN 0
END



