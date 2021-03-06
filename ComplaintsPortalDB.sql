USE [ComplaintsPortal]
GO
/****** Object:  Table [dbo].[AdhaarXContactNumber]    Script Date: 10/11/2017 15:47:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdhaarXContactNumber](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdhaarNumber] [varchar](20) NOT NULL,
	[ContactNumber] [varchar](20) NOT NULL,
 CONSTRAINT [PK_AdhaarXContactNumber] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdhaarXOTP]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdhaarXOTP](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdhaarNumber] [varchar](20) NOT NULL,
	[OTP] [varchar](10) NOT NULL,
 CONSTRAINT [PK_AdhaarXOTP] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[PinCode] [char](6) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Complaints]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Complaints](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[VillageId] [int] NULL,
	[LocalityId] [int] NOT NULL,
	[DepartmentTypeId] [int] NOT NULL,
	[ComplaintTypeId] [int] NOT NULL,
	[ReportingPersonFirstName] [varchar](100) NOT NULL,
	[ReportingPersonLastName] [varchar](100) NOT NULL,
	[ReportingPersonAdhaarId] [varchar](50) NOT NULL,
	[ReportingPersonContactNumber] [varchar](50) NOT NULL,
	[ReportingTime] [datetime] NOT NULL,
	[CurrentStatusId] [int] NOT NULL,
	[CurrentEscalationNumber] [int] NULL DEFAULT ((0)),
	[OTP] [varchar](6) NOT NULL,
	[ComplaintVerifiedViaOTP] [bit] NOT NULL DEFAULT ((0)),
	[IsEscalated] [bit] NOT NULL DEFAULT ((0)),
	[Description] [varchar](1000) NULL,
	[DepartmentId] [int] NOT NULL,
	[ClosingTime] [datetime] NULL,
	[Image] [varchar](50) NULL,
 CONSTRAINT [PK_Complaints] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ComplaintStatus]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComplaintStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ComplaintStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ComplaintTypes]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComplaintTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[DepartmentTypeId] [int] NOT NULL,
 CONSTRAINT [PK_ComplaintTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ComplaintXEscalationLevel]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComplaintXEscalationLevel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ComplaintId] [int] NOT NULL,
	[EscalationLevelNumber] [int] NOT NULL,
	[EscalationTime] [datetime] NOT NULL,
	[EscalationReason] [varchar](500) NULL,
 CONSTRAINT [PK_ComplaintXEscalationLevel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ComplaintXStatus]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComplaintXStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ComplaintId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[StatusAssignTime] [datetime] NOT NULL,
	[StatusChangeSummary] [varchar](500) NULL,
 CONSTRAINT [PK_ComplaintXStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DepartmentDesignations]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DepartmentDesignations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_DepartmentDesignations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DepartmentEscalationLevels]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DepartmentEscalationLevels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[EscalationLevelName] [varchar](100) NOT NULL,
	[DesignatedOfficialId] [int] NOT NULL,
	[LevelNumber] [int] NOT NULL,
 CONSTRAINT [PK_DepartmentEscalationLevels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentTypeId] [int] NOT NULL,
	[Name] [varchar](500) NOT NULL,
	[StateId] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[VillageId] [int] NULL,
	[LocalityId] [int] NOT NULL,
	[OfficeAddress] [varchar](500) NOT NULL,
	[Website] [varchar](50) NULL,
	[ContactEmails] [varchar](200) NULL,
	[ContactNumbers] [varchar](100) NULL,
	[ContactTimings] [varchar](50) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DepartmentTypes]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DepartmentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](500) NOT NULL,
 CONSTRAINT [PK_DepartmentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DepartmentXAreaIncharges]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentXAreaIncharges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[StateId] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[VillageId] [int] NULL,
	[LocalityId] [int] NOT NULL,
	[InchargeId] [int] NOT NULL,
 CONSTRAINT [PK_DepartmentXAreaIncharges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepartmentXAreaOnDuty]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentXAreaOnDuty](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[StateID] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[VillageId] [int] NULL,
	[LocalityId] [int] NOT NULL,
	[OnDutyPersonId] [int] NOT NULL,
	[DutyTimeFrom] [datetime] NULL,
	[DutyTimeTo] [datetime] NULL,
 CONSTRAINT [PK_DepartmentXAreaOnDuty] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepartmentXOfficials]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentXOfficials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[GovernmentOfficialId] [int] NOT NULL,
	[DesignationId] [int] NOT NULL,
 CONSTRAINT [PK_DepartmentXOfficials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GovernmentOfficials]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GovernmentOfficials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[ContactNumber] [varchar](100) NULL,
	[ContactEmail] [varchar](100) NULL,
	[Picture] [varchar](100) NULL,
	[DesignationId] [int] NOT NULL,
	[OfficialCode] [varchar](20) NOT NULL,
 CONSTRAINT [PK_GovernmentOfficials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localities]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NOT NULL,
	[VillageId] [int] NULL,
	[Name] [varchar](100) NOT NULL,
	[PinCode] [char](6) NOT NULL,
	[Latitude] [varchar](50) NULL,
	[Longitude] [varchar](50) NULL,
 CONSTRAINT [PK_Localities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OfficialXComplaintsAssigned]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfficialXComplaintsAssigned](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OfficialId] [int] NOT NULL,
	[ComplaintId] [int] NOT NULL,
	[AssignedOn] [datetime] NOT NULL,
	[IsEscalated] [bit] NOT NULL,
 CONSTRAINT [PK_OfficialXComplaintsAssigned] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[States]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[States](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Villages]    Script Date: 10/11/2017 15:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Villages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[PinCode] [char](6) NOT NULL,
 CONSTRAINT [PK_Villages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_States] FOREIGN KEY([StateId])
REFERENCES [dbo].[States] ([Id])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_States]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Cities]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_ComplaintStatus] FOREIGN KEY([CurrentStatusId])
REFERENCES [dbo].[ComplaintStatus] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_ComplaintStatus]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_ComplaintTypes] FOREIGN KEY([ComplaintTypeId])
REFERENCES [dbo].[ComplaintTypes] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_ComplaintTypes]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Departments]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_DepartmentTypes] FOREIGN KEY([DepartmentTypeId])
REFERENCES [dbo].[DepartmentTypes] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_DepartmentTypes]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Localities] FOREIGN KEY([LocalityId])
REFERENCES [dbo].[Localities] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Localities]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_States] FOREIGN KEY([StateId])
REFERENCES [dbo].[States] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_States]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Villages] FOREIGN KEY([VillageId])
REFERENCES [dbo].[Villages] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Villages]
GO
ALTER TABLE [dbo].[ComplaintTypes]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintTypes_DepartmentTypes] FOREIGN KEY([DepartmentTypeId])
REFERENCES [dbo].[DepartmentTypes] ([Id])
GO
ALTER TABLE [dbo].[ComplaintTypes] CHECK CONSTRAINT [FK_ComplaintTypes_DepartmentTypes]
GO
ALTER TABLE [dbo].[ComplaintXEscalationLevel]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintXEscalationLevel_Complaints] FOREIGN KEY([ComplaintId])
REFERENCES [dbo].[Complaints] ([Id])
GO
ALTER TABLE [dbo].[ComplaintXEscalationLevel] CHECK CONSTRAINT [FK_ComplaintXEscalationLevel_Complaints]
GO
ALTER TABLE [dbo].[ComplaintXStatus]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintXStatus_Complaints] FOREIGN KEY([ComplaintId])
REFERENCES [dbo].[Complaints] ([Id])
GO
ALTER TABLE [dbo].[ComplaintXStatus] CHECK CONSTRAINT [FK_ComplaintXStatus_Complaints]
GO
ALTER TABLE [dbo].[ComplaintXStatus]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintXStatus_ComplaintStatus] FOREIGN KEY([StatusId])
REFERENCES [dbo].[ComplaintStatus] ([Id])
GO
ALTER TABLE [dbo].[ComplaintXStatus] CHECK CONSTRAINT [FK_ComplaintXStatus_ComplaintStatus]
GO
ALTER TABLE [dbo].[DepartmentEscalationLevels]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentEscalationLevels_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[DepartmentEscalationLevels] CHECK CONSTRAINT [FK_DepartmentEscalationLevels_Departments]
GO
ALTER TABLE [dbo].[DepartmentEscalationLevels]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentEscalationLevels_GovernmentOfficials] FOREIGN KEY([DesignatedOfficialId])
REFERENCES [dbo].[GovernmentOfficials] ([Id])
GO
ALTER TABLE [dbo].[DepartmentEscalationLevels] CHECK CONSTRAINT [FK_DepartmentEscalationLevels_GovernmentOfficials]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Cities]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_DepartmentTypes] FOREIGN KEY([DepartmentTypeId])
REFERENCES [dbo].[DepartmentTypes] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_DepartmentTypes]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Localities] FOREIGN KEY([LocalityId])
REFERENCES [dbo].[Localities] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Localities]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_States] FOREIGN KEY([StateId])
REFERENCES [dbo].[States] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_States]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Villages] FOREIGN KEY([VillageId])
REFERENCES [dbo].[Villages] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Villages]
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaIncharges_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges] CHECK CONSTRAINT [FK_DepartmentXAreaIncharges_Cities]
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaIncharges_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges] CHECK CONSTRAINT [FK_DepartmentXAreaIncharges_Departments]
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaIncharges_GovernmentOfficials] FOREIGN KEY([InchargeId])
REFERENCES [dbo].[GovernmentOfficials] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges] CHECK CONSTRAINT [FK_DepartmentXAreaIncharges_GovernmentOfficials]
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaIncharges_Localities] FOREIGN KEY([LocalityId])
REFERENCES [dbo].[Localities] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges] CHECK CONSTRAINT [FK_DepartmentXAreaIncharges_Localities]
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaIncharges_States] FOREIGN KEY([StateId])
REFERENCES [dbo].[States] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges] CHECK CONSTRAINT [FK_DepartmentXAreaIncharges_States]
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaIncharges_Villages] FOREIGN KEY([VillageId])
REFERENCES [dbo].[Villages] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaIncharges] CHECK CONSTRAINT [FK_DepartmentXAreaIncharges_Villages]
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaOnDuty_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty] CHECK CONSTRAINT [FK_DepartmentXAreaOnDuty_Departments]
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaOnDuty_GovernmentOfficials] FOREIGN KEY([OnDutyPersonId])
REFERENCES [dbo].[GovernmentOfficials] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty] CHECK CONSTRAINT [FK_DepartmentXAreaOnDuty_GovernmentOfficials]
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaOnDuty_Localities] FOREIGN KEY([VillageId])
REFERENCES [dbo].[Localities] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty] CHECK CONSTRAINT [FK_DepartmentXAreaOnDuty_Localities]
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaOnDuty_States] FOREIGN KEY([StateID])
REFERENCES [dbo].[States] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty] CHECK CONSTRAINT [FK_DepartmentXAreaOnDuty_States]
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXAreaOnDuty_Villages] FOREIGN KEY([VillageId])
REFERENCES [dbo].[Villages] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXAreaOnDuty] CHECK CONSTRAINT [FK_DepartmentXAreaOnDuty_Villages]
GO
ALTER TABLE [dbo].[DepartmentXOfficials]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXOfficials_DepartmentDesignations] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[DepartmentDesignations] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXOfficials] CHECK CONSTRAINT [FK_DepartmentXOfficials_DepartmentDesignations]
GO
ALTER TABLE [dbo].[DepartmentXOfficials]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXOfficials_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXOfficials] CHECK CONSTRAINT [FK_DepartmentXOfficials_Departments]
GO
ALTER TABLE [dbo].[DepartmentXOfficials]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentXOfficials_GovernmentOfficials] FOREIGN KEY([GovernmentOfficialId])
REFERENCES [dbo].[GovernmentOfficials] ([Id])
GO
ALTER TABLE [dbo].[DepartmentXOfficials] CHECK CONSTRAINT [FK_DepartmentXOfficials_GovernmentOfficials]
GO
ALTER TABLE [dbo].[GovernmentOfficials]  WITH CHECK ADD  CONSTRAINT [FK_GovernmentOfficials_DepartmentDesignations] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[DepartmentDesignations] ([Id])
GO
ALTER TABLE [dbo].[GovernmentOfficials] CHECK CONSTRAINT [FK_GovernmentOfficials_DepartmentDesignations]
GO
ALTER TABLE [dbo].[Localities]  WITH CHECK ADD  CONSTRAINT [FK_Localities_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Localities] CHECK CONSTRAINT [FK_Localities_Cities]
GO
ALTER TABLE [dbo].[Localities]  WITH CHECK ADD  CONSTRAINT [FK_Localities_Villages] FOREIGN KEY([VillageId])
REFERENCES [dbo].[Villages] ([Id])
GO
ALTER TABLE [dbo].[Localities] CHECK CONSTRAINT [FK_Localities_Villages]
GO
ALTER TABLE [dbo].[OfficialXComplaintsAssigned]  WITH CHECK ADD  CONSTRAINT [FK_OfficialXComplaintsAssigned_Complaints] FOREIGN KEY([ComplaintId])
REFERENCES [dbo].[Complaints] ([Id])
GO
ALTER TABLE [dbo].[OfficialXComplaintsAssigned] CHECK CONSTRAINT [FK_OfficialXComplaintsAssigned_Complaints]
GO
ALTER TABLE [dbo].[OfficialXComplaintsAssigned]  WITH CHECK ADD  CONSTRAINT [FK_OfficialXComplaintsAssigned_GovernmentOfficials] FOREIGN KEY([OfficialId])
REFERENCES [dbo].[GovernmentOfficials] ([Id])
GO
ALTER TABLE [dbo].[OfficialXComplaintsAssigned] CHECK CONSTRAINT [FK_OfficialXComplaintsAssigned_GovernmentOfficials]
GO
ALTER TABLE [dbo].[Villages]  WITH CHECK ADD  CONSTRAINT [FK_Villages_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Villages] CHECK CONSTRAINT [FK_Villages_Cities]
GO
