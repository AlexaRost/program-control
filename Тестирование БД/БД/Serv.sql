CREATE TABLE [dbo].[Serv] (
    [Id_Serv] INT          NOT NULL,
    [Typ]     VARCHAR (50) NOT NULL,
    [Cost]    INT          NOT NULL,
    [Stat]    VARCHAR (30) NOT NULL,
    [Cond]    VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Serv] ASC),
    CHECK ([Cost]>=(500) AND [Cost]<=(100000)),
    CHECK ([Stat]='Выполняется' OR [Stat]='Выполнен' OR [Stat]='Отменен')
);

