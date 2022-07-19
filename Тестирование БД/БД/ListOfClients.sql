-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE ListOfClients (@Tp varchar(30)) AS
BEGIN
SELECT  SurCl, Category, NumCl, Cty FROM Client
JOIN Contract ON Contract.Id_Cl = Client.Id_Cl
JOIN Serv ON Serv.Id_Serv = Contract.Id_Serv
WHERE Typ = @Tp ORDER BY SurCl;
END
