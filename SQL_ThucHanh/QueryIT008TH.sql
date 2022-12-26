﻿CREATE DATABASE IT008TH
GO

USE IT008TH
GO

CREATE TABLE LOP
(
	MaLop NVARCHAR(10) PRIMARY KEY,
	TenLop NVARCHAR(50),
	SL INT, 
)
GO

CREATE TABLE SINHVIEN
(
	MSSV NVARCHAR(8) PRIMARY KEY, 
	TENSV NVARCHAR(50),
	MALOP NVARCHAR(10),
)
GO

INSERT INTO SINHVIEN VALUES ('21520455', N'Phan Tuấn Thành', 'PMCL2021')
INSERT INTO SINHVIEN VALUES ('21520519', N'Lê Thanh Tuấn', 'PMCL2021')
INSERT INTO SINHVIEN VALUES ('21520638', N'Nguyễn Phúc Bình', 'PMCL2021')

INSERT INTO LOP VALUES ('PMCL2021', N'Phần mềm chất lượng 2021', 3)
INSERT INTO LOP VALUES ('HTCL2021', N'Hệ thông chất lượng 2021', 0)
INSERT INTO LOP VALUES ('KHCL2021', N'Khoa học chất lượng 2021', 0)

ALTER TABLE SINHVIEN ADD CONSTRAINT FK_SV_LOP FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
