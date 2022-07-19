SELECT SUM(Serv.Cost) FROM Lab4_MKP.dbo.Client
JOIN Lab4_MKP.dbo.Contract ON Contract.Id_Cl = Client.Id_Cl
JOIN Lab4_MKP.dbo.Serv ON Serv.Id_Serv = Contract.Id_Serv 
WHERE SurCl = 'Петров';