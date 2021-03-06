USE [Cyber_Cafe]
GO
/****** Object:  StoredProcedure [dbo].[ViewSupply]    Script Date: 18/12/2019 09:50:26 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ViewSupply]
	-- Add the parameters for the stored procedure here
	@type varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @type IN ('Food', 'Drink')
	BEGIN
		SELECT * FROM FoodNDrinks WHERE [type] = @type
	END
	ELSE
	BEGIN
		SELECT * FROM FoodNDrinks
	END
END

GO
