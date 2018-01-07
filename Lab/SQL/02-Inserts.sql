USE DoctorWho;

INSERT INTO Cities (FullName) VALUES ('Blumenau');
INSERT INTO Cities (FullName) VALUES ('São José do Rio Preto');
GO

INSERT INTO Specialties (Descriptions) VALUES ('Cardiologista');
INSERT INTO Specialties (Descriptions) VALUES ('Neurologista');
GO

Insert Into  Users (FullName, LoginSystem, PasswordSystem, Email) Values ('Administrador', 'admin', '40BD001563085FC35165329EA1FF5C5ECBDBBEEF','admin@cdmm.com');