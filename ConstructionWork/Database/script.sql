SET IDENTITY_INSERT [dbo].[Plan] ON
INSERT INTO [dbo].[Plan] ([ID], [PlanCode], [Description], [StartDate], [EndDate]) VALUES (1, 1, N'Worked would be Professionol', N'2021-01-01 11:01:00', N'2022-01-27 11:01:00')
INSERT INTO [dbo].[Plan] ([ID], [PlanCode], [Description], [StartDate], [EndDate]) VALUES (2, 2, N'Need driver for Construction Truck', N'2021-01-15 11:11:00', N'2021-12-30 11:11:00')
SET IDENTITY_INSERT [dbo].[Plan] OFF
SET IDENTITY_INSERT [dbo].[Vaccencie] ON
INSERT INTO [dbo].[Vaccencie] ([JobID], [JobType], [StartDate], [EndDate]) VALUES (1, N'Manager', N'1/01/2021', N'1/01/2022')
INSERT INTO [dbo].[Vaccencie] ([JobID], [JobType], [StartDate], [EndDate]) VALUES (2, N'Driver', N'2/02/2021', N'30/12/2021')
INSERT INTO [dbo].[Vaccencie] ([JobID], [JobType], [StartDate], [EndDate]) VALUES (3, N'Accountant', N'24/01/2021', N'24/12/2021')
INSERT INTO [dbo].[Vaccencie] ([JobID], [JobType], [StartDate], [EndDate]) VALUES (4, N'Plumber', N'12/06/2021', N'28/10/2021')
SET IDENTITY_INSERT [dbo].[Vaccencie] OFF
SET IDENTITY_INSERT [dbo].[Worker] ON
INSERT INTO [dbo].[Worker] ([StaffID], [Staffname], [StaffDoB], [StaffAddress]) VALUES (1, N'Iqbal', N'19/12/1999', N'3/16 Oakley Avenue')
INSERT INTO [dbo].[Worker] ([StaffID], [Staffname], [StaffDoB], [StaffAddress]) VALUES (2, N'Parvesh', N'28/11/1998', N'3/16 knighton road')
INSERT INTO [dbo].[Worker] ([StaffID], [Staffname], [StaffDoB], [StaffAddress]) VALUES (3, N'Joy', N'4/05/1995', N'40 Horne Street')
SET IDENTITY_INSERT [dbo].[Worker] OFF
