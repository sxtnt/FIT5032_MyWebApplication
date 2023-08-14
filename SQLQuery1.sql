-- Create table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [Lastlame]  NVARCHAR (MAX) NOT NULL,
    [UserId]    NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Create table 'Units'
CREATE TABLE [dbo].[Units] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [PatientId]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patients] ([Id])
);
