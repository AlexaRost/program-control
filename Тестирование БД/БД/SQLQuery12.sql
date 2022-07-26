USE [Lab4_MKP]
GO
/****** Object:  StoredProcedure [dbo].[ListOfClients]    Script Date: 13.10.2021 16:10:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ListOfClients] (@Tp varchar(30)) AS
BEGIN
SELECT Id_Cl, SurCl, Category, NumCl, Cty FROM Client
JOIN Contract ON Contract.Id_Cl = Client.Id_Cl
JOIN Serv ON Serv.Id_Serv = Contract.Id_Serv
WHERE Typ = @Tp ORDER BY SurCl;
END

