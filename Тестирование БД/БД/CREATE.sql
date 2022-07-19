CREATE TABLE Employee
(
Id_Emp INTEGER NOT NULL PRIMARY KEY,
Sal INTEGER NOT NULL CHECK (Sal between 1000 and 80000),
Sur VARCHAR(30) NOT NULL,
Num INTEGER NOT NULL,
);

CREATE TABLE Client
(
Id_Cl INTEGER NOT NULL PRIMARY KEY,
SurCl VARCHAR(30) NOT NULL ,
Category INT NOT NULL DEFAULT (1),
NumCl INTEGER NOT NULL,
Cty VARCHAR(20) NOT NULL,
);

CREATE TABLE Serv
(
Id_Serv INTEGER NOT NULL PRIMARY KEY,
Typ VARCHAR(30) NOT NULL,
Cost INTEGER NOT NULL CHECK (Cost between 500 and 100000),
Stat VARCHAR(30) NOT NULL CHECK (Stat IN('�������','��������','�����������')),
Cond VARCHAR(30) NOT NULL,
);

CREATE TABLE Contract
(
Id_Cont INTEGER NOT NULL PRIMARY KEY,
Dte DATETIME NOT NULL,
Dte_end DATETIME,
Id_Serv INTEGER NOT NULL FOREIGN KEY REFERENCES Serv(Id_Serv)
ON DELETE CASCADE
 ON UPDATE  CASCADE,
Id_Cl INTEGER NOT NULL FOREIGN KEY REFERENCES Client(Id_Cl)
ON DELETE CASCADE
 ON UPDATE  CASCADE,
Id_Emp INTEGER NOT NULL FOREIGN KEY REFERENCES Employee(Id_Emp) 
ON DELETE CASCADE
 ON UPDATE  CASCADE
);
