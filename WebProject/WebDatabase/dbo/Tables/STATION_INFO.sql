CREATE TABLE [dbo].[STATION_INFO] (
    [SI_SN]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [STATION_CODE] VARCHAR (20) NULL,
    [CITY]         VARCHAR (20) NULL,
    [STATION_NAME] VARCHAR (20) NULL,
    CONSTRAINT [PK_STATION_INFO] PRIMARY KEY CLUSTERED ([SI_SN] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_STATION_INFO_SI_SN]
    ON [dbo].[STATION_INFO]([SI_SN] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'PK, 自動流水號', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STATION_INFO', @level2type = N'COLUMN', @level2name = N'SI_SN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'測站代號', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STATION_INFO', @level2type = N'COLUMN', @level2name = N'STATION_CODE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'城市', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STATION_INFO', @level2type = N'COLUMN', @level2name = N'CITY';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'測站名稱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STATION_INFO', @level2type = N'COLUMN', @level2name = N'STATION_NAME';

