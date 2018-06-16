CREATE DATABASE [Pragim_WCF];
GO
USE [Pragim_WCF]
GO
Create Table tblEmployee
(
 Id int,
 Name nvarchar(50),
 Gender nvarchar(50),
 DateOfBirth datetime
)
GO

Insert into tblEmployee values (1, 'Mark', 'Male', '10/10/1980')
Insert into tblEmployee values (2, 'Mary', 'Female', '11/10/1981')
Insert into tblEmployee values (3, 'John', 'Male', '8/10/1979')
GO

Create procedure spGetEmployee
@Id int
as
Begin
 Select Id, Name, Gender, DateOfBirth
 from tblEmployee 
 where Id = @Id
End
GO

Create procedure spSaveEmployee
@Id int,
@Name nvarchar(50),
@Gender nvarchar(50),
@DateOfBirth DateTime
as
Begin
 Insert into tblEmployee
 values (@Id, @Name, @Gender, @DateOfBirth)
End
GO
