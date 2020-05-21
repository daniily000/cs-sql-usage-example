CREATE DATABASE PersonalDatabsae;
GO

USE PersonalDatabsae;
GO

CREATE TABLE MainDataTable
   (id int PRIMARY KEY NOT NULL,  
   ObjectName varchar(25) NOT NULL,  
   ObjectDescription varchar(2000))
GO