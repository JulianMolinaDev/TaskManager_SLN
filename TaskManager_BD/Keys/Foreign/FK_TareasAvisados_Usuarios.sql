ALTER TABLE [SCH_TaskManager].[TBL_TareasAvisados]
	ADD CONSTRAINT [FK_TareasAvisados_Usuarios]
	FOREIGN KEY (IdUsuario)
	REFERENCES [SCH_TaskManager].[TBL_Usuarios] (Id)
