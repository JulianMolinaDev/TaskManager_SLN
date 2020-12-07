CREATE TABLE [SCH_TaskManager].[TBL_Proyectos]
(
	[Id] INT NOT NULL IDENTITY(1,1),
    [IdEmpresa] INT NOT NULL,
    [Nombre] VARCHAR(50) NOT NULL, 
    [Descripcion] VARCHAR(50) NOT NULL, 
    [FechaAlta] SMALLDATETIME NOT NULL DEFAULT GETDATE(), 
    [EsActivo] BIT NOT NULL DEFAULT 1
)
