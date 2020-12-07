ALTER TABLE [SCH_TaskManager].[TBL_TareasAvisados]
	ADD CONSTRAINT [FK_TareasAvisados_Tareas]
	FOREIGN KEY (IdTarea)
	REFERENCES [SCH_TaskManager].[TBL_Tareas] (Id)
