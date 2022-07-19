CREATE TABLE [dbo].[Contract] (
    [Id_Cont] INT      NOT NULL,
    [Dte]     DATETIME NOT NULL,
    [Dte_end] DATETIME NULL,
    [Id_Serv] INT      NOT NULL,
    [Id_Cl]   INT      NOT NULL,
    [Id_Emp]  INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Cont] ASC),
    FOREIGN KEY ([Id_Cl]) REFERENCES [dbo].[Client] ([Id_Cl]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([Id_Emp]) REFERENCES [dbo].[Employee] ([Id_Emp]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([Id_Serv]) REFERENCES [dbo].[Serv] ([Id_Serv]) ON DELETE CASCADE ON UPDATE CASCADE
);

