CREATE TABLE [dbo].[Employee] (
    [Id_Emp] INT          NOT NULL,
    [Sal]    INT          NOT NULL,
    [Sur]    VARCHAR (30) NOT NULL,
    [Num]    BIGINT       NOT NULL,
    [Post]   VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id_Emp] ASC),
    CHECK ([Sal]>=(1000) AND [Sal]<=(80000))
);

