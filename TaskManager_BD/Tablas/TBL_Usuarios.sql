CREATE TABLE [SCH_TaskManager].[TBL_Usuarios]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [IdEmpresa] INT NOT NULL,
    [Nombre] VARCHAR(50) NOT NULL, 
    [Apellidos] VARCHAR(50) NOT NULL, 
    [FechaNacimiento] DATE NOT NULL, 
    [Correo] VARCHAR(50) NOT NULL,
    [Password] VARBINARY(MAX) NOT NULL,    
    [FechaAlta] SMALLDATETIME NULL DEFAULT GETDATE(), 
    [EsActivo] BIT NULL DEFAULT 1
)
