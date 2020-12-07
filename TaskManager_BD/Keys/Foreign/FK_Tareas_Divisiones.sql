ALTER TABLE [SCH_TaskManager].[TBL_Tareas]
	ADD CONSTRAINT [FK_Tareas_Divisiones]
	FOREIGN KEY (IdDivision)
	REFERENCES [SCH_TaskManager].[TBL_Tareas] (Id)
