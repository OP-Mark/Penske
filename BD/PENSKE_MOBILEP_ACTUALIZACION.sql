SELECT * FROM Inventory
SELECT * FROM InventoryStatus
SELECT * FROM Users


--CREATE TABLE InventoryStatus(
--ID INT PRIMARY KEY IDENTITY,
--NameStatus NVARCHAR(20) NOT NULL,
--Active BIT
--)

--INSERT INTO InventoryStatus VALUES ('IN-TRANSIT', 1)
--INSERT INTO InventoryStatus VALUES ('PUT-AWAY', 1)
--INSERT INTO InventoryStatus VALUES ('SHIPPED', 1)
--INSERT INTO InventoryStatus VALUES ('CYCLE-COUNT', 1)

--UPDATE Inventory SET Status = '1' WHERE Status = 'IN-TRANSIT' 
--UPDATE Inventory SET Status = '2' WHERE Status = 'PUT-AWAY' 
--UPDATE Inventory SET Status = '3' WHERE Status = 'SHIPPED' 
--UPDATE Inventory SET Status = '4' WHERE Status = 'CYCLE-COUNT' 

--ALTER TABLE Inventory ALTER COLUMN Status INT

--UPDATE Users SET Email = LOWER(Email) WHERE Email = Email
--UPDATE Users SET Active = 1
--DELETE Users WHERE Email IS NULL AND Password IS NULL AND FullName IS NULL



