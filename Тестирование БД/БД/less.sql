-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE less (@Cos Integer) AS
BEGIN
SELECT  Client.SurCl, Client.Category, Client.NumCl, Client.Cty, Serv.Cost, Serv.Typ FROM Client
JOIN Contract ON Contract.Id_Cl = Client.Id_Cl
JOIN Serv ON Serv.Id_Serv = Contract.Id_Serv
WHERE Serv.Cost <= @Cos ;
END
