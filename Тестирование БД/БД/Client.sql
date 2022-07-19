CREATE TABLE [dbo].[Client] (
    [Id_Cl]    INT          NOT NULL,
    [SurCl]    VARCHAR (30) NOT NULL,
    [Category] INT          DEFAULT ((1)) NOT NULL,
    [NumCl]    BIGINT       NOT NULL,
    [Cty]      VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Cl] ASC)
);

