CREATE TABLE [SCH_TaskManager].[TBL_Tareas]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [IdDivision] INT NULL, 
    [IdUsuarioResponsable] INT NOT NULL, 
    [Titulo] VARCHAR(50) NOT NULL, 
    [Descripcion] VARCHAR(500) NOT NULL,
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE(), 
    [EsActivo] BIT NOT NULL DEFAULT 1, 
    [FechaTermino] DATE NOT NULL, 
    [FechaInicio] DATE NOT NULL, 
    [FechaTerminoReal] DATE NULL
)
