-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[Summ] (@Sur varchar(30), @SumC int OUTPUT) AS
BEGIN
SELECT @SumC = SUM(Serv.Cost) FROM Client
JOIN Contract ON Contract.Id_Cl = Client.Id_Cl
JOIN Serv ON Serv.Id_Serv = Contract.Id_Serv 
WHERE SurCl = @Sur;
END
