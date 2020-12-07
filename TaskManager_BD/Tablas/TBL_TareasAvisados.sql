CREATE TABLE [SCH_TaskManager].[TBL_TareasAvisados]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [IdTarea] INT NOT NULL, 
    [IdUsuario] INT NOT NULL,
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE(), 
    [EsActivo] BIT NOT NULL DEFAULT 1, 
    [EsVisto] BIT NULL DEFAULT 0 
)
