CREATE TABLE [dbo].[Gazdik] (
    [GazdiID]     VARCHAR (50)  NOT NULL,
    [Nev]         VARCHAR (100) NULL,
    [Cim]         VARCHAR (255) NULL,
    [Telefonszam] VARCHAR (50)  NULL,
    [Email]       VARCHAR (100) NULL,
    [AllatID]     VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([GazdiID] ASC),
    CONSTRAINT [FK_Gazdik_Allatok] FOREIGN KEY ([AllatID]) REFERENCES [dbo].[Allatok] ([AllatID])
);

