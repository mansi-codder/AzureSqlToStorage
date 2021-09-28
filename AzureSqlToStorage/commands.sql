CREATE TABLE Dishes
(
   DishID int,
   DishImage varchar(1000),
   DishName varchar(1000),
   Rating numeric(2,1)
)

INSERT INTO Dishes(DishID ,DishImage ,DishName ,Rating) VALUES(1,'https://demoostorageaccount.blob.core.windows.net/data/choleBhatore.jpg','chole Bhatore',4.5)
INSERT INTO Dishes(DishID ,DishImage ,DishName ,Rating) VALUES(1,'https://demoostorageaccount.blob.core.windows.net/data/dosa.jpg','Sambhar Dosa',3.5)
INSERT INTO Dishes(DishID ,DishImage ,DishName ,Rating) VALUES(1,'https://demoostorageaccount.blob.core.windows.net/data/Thali.jpg','North Indian Thali',4.5)


SELECT * FROM Dishes
