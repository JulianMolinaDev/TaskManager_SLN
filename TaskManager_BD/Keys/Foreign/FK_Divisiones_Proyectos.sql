ALTER TABLE [SCH_TaskManager].[TBL_Divisiones]
	ADD CONSTRAINT [FK_Divisiones_Proyectos]
	FOREIGN KEY (IdProyecto)
	REFERENCES [SCH_TaskManager].[TBL_Proyectos] (Id)
