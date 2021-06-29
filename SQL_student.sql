
-- 
CREATE TABLE dbo.Student(cnt INT IDENTITY(1, 1) PRIMARY KEY,
name VARCHAR(50) NOT NULL,
age INT,
score INT
);

DROP TABLE dbo.Student;