CREATE TABLE Rooms (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomType NVARCHAR(50) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Cost DECIMAL(10, 2) NOT NULL,
    HasWiFi BIT NOT NULL,
    HasMinibar BIT NOT NULL,
    HasRoomService BIT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
); 