﻿CREATE TABLE [SCH_TaskManager].[TBL_Empresas]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Nombre] VARCHAR(50) NOT NULL, 
    [UrlImagen] VARCHAR(50) NOT NULL, 
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE(), 
    [EsActivo] BIT NOT NULL DEFAULT 1
)
