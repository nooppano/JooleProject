INSERT INTO tblManufacture (ManufactureID, ManufactureName )
VALUES (1, N'Big Ass'), 
       (2, N'Emerson'),
       (3, N'Minka');
GO

INSERT INTO [dbo].[tblType] ([TypeID], [UseType], [Application], [MountingLocation], [Accessories], [ModelYear]) 
VALUES (1, N'Commercial', N'Indoor', N'Roof', N'With light', 2014),
       (2, N'Commercial', N'Outdoor', N'Roof', N'With light', 2016);

GO

INSERT INTO [dbo].[tblTechSpecFilter] ([TechSpecFilterID], [Min], [Max]) 
VALUES (1, 100, 240),
       (2, 1.95, 21.14),
       (3, 35, 200);
GO

INSERT INTO [dbo].[tblUser] ([UserID], [Username], [Password], [Email], [Photo]) 
VALUES (1, N'Itlize1', N'12345', N'abc@gmail.com', N'image1.jpg'),
       (2, N'romeo', N'12345', N'azert@gmail.com', N'image2.jpg');

GO

INSERT INTO [dbo].[tblCategory] ([CatID], [CategoryName]) 
VALUES (1, N'Fans'),
       (2, N'Vaccums'),
       (3, N'Toasters');

GO

INSERT INTO [dbo].[tblSubCategory] ([SubCatID], [CatID], [SubCatName]) 
VALUES (1, 1, N'Mechanical'),
        (2, 1, N'Electrical'),
        (3, 2, N'Home'),
        (4, 2, N'Business'),
        (5, 3, N'Business');

GO

INSERT INTO [dbo].[tblProduct] ([ProductID], [ManufactureID], [TypeID], [CatID], [SubCatID], [TechSpecFilterID], [Name], [Model], [Airflow], [MaxPower], [SoundVolume], [FanDiameter]) 
VALUES (1, 1, 1, 1, 1, 1, N'Big Ass', N'Haiku H Series', 100, 25, 25, 30),
(2, 2, 2, 2, 2, 2, N'BigASS ', N'Haiku Yamaha', 60, 85, 35, 25);
GO


