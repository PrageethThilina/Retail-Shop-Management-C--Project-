CREATE TABLE [dbo].[Stock] (
    [Item_Id]       VARCHAR(50)           NOT NULL,
    [Item_Name]     NVARCHAR (50) NULL,
    [Item_Price]    INT           NULL,
    [Item_Quantity] INT           NULL,
    CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED ([Item_Id] ASC)
);

