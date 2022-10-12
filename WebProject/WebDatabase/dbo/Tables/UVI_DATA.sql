CREATE TABLE [dbo].[UVI_DATA] (
    [UD_SN]           BIGINT           IDENTITY (1, 1) NOT NULL,
    [STATION_CODE]    VARCHAR (20)     NULL,
    [UVI_VALUE]       DECIMAL (18, 12) NULL,
    [OBSERVATION_DTM] VARCHAR (20)     NULL,
    [CREATE_USER]     NVARCHAR (20)    NULL,
    [CREATE_DTM]      DATETIME         DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_UVI_DATA] PRIMARY KEY CLUSTERED ([UD_SN] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_UVI_DATA_UD_SN]
    ON [dbo].[UVI_DATA]([UD_SN] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'PK, 自動流水號', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'UVI_DATA', @level2type = N'COLUMN', @level2name = N'UD_SN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'測站代號', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'UVI_DATA', @level2type = N'COLUMN', @level2name = N'STATION_CODE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'紫外線指數最大值', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'UVI_DATA', @level2type = N'COLUMN', @level2name = N'UVI_VALUE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'觀測時間', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'UVI_DATA', @level2type = N'COLUMN', @level2name = N'OBSERVATION_DTM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'建立者', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'UVI_DATA', @level2type = N'COLUMN', @level2name = N'CREATE_USER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'建立時間', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'UVI_DATA', @level2type = N'COLUMN', @level2name = N'CREATE_DTM';

