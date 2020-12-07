ALTER TABLE [SCH_TaskManager].[TBL_Proyectos]
	ADD CONSTRAINT [FK_Proyectos_Empresas]
	FOREIGN KEY (IdEmpresa)
	REFERENCES [SCH_TaskManager].[TBL_Empresas] (Id)
