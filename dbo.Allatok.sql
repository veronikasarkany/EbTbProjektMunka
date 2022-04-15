CREATE TABLE [dbo].[Allatok] (
    [AllatokID]    CHAR (15)     NOT NULL,
    [Nev]          VARCHAR (100) NULL,
    [SzuletesiIdo] DATE          NULL,
    [GazdiID]      INT           NULL,
    [FajID]        INT           NULL,
    [FebkID]       INT           NULL,
    [OltKezID]     INT           NULL,
    PRIMARY KEY CLUSTERED ([AllatokID] ASC),
    CONSTRAINT [FK_Allatok_Gazdik] FOREIGN KEY ([GazdiID]) REFERENCES [dbo].[Gazdik] ([GazdiID]),
    CONSTRAINT [FK_Allatok_BejegyzesekKezelesek] FOREIGN KEY ([FebkID]) REFERENCES [dbo].[BejegyzesekKezelesek] ([FebkID]),
    CONSTRAINT [FK_Allatok_OltasokKezelesek] FOREIGN KEY ([OltKezID]) REFERENCES [dbo].[OltasokKezelesek] ([OltKezID]),
    CONSTRAINT [FK_Allatok_FajFajta] FOREIGN KEY ([FajID]) REFERENCES [dbo].[FajFajta] ([FajID])
);

