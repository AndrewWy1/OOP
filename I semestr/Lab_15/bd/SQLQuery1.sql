CREATE DATABASE OOP_15_DB
GO

USE OOP_15_DB

CREATE TABLE students_mark
(
	first_name NVARCHAR(20),
	last_name NVARCHAR(20),
	group_name NVARCHAR(10) NOT NULL,
	average_mark DECIMAL(5, 1) NOT NULL
		CONSTRAINT CK_average_mark CHECK(average_mark BETWEEN 0 AND 5),

	subject_min_aver_score NVARCHAR(20)NULL,
	subject_max_aver_score NVARCHAR(20) NULL,

	PRIMARY KEY(first_name, last_name)
	
)
GO 

USE OOP_15_DB

INSERT INTO students_mark
VALUES (N'Влад', N'Крупняк', N'KN', 2.7, N'OOP', N'TI'),
	   (N'Олкса', N'Довбуш', N'IPZ', 3.1, N'TA', N'JS'),
	   (N'Степан', N'Гіга', N'KI', 4.4, N'TI', N'OS'),
	   (N'Іво', N'Бобул', N'KI', 1.9, N'JS', N'OOP'),
	   (N'Петрик', N'Порох', N'KN', 4.9, N'English', N'OS'),
	   (N'Степан', N'Бандера', N'IPZ', 2.1, N'OOP', N'English'),
	   (N'Гомер', N'Сімпсон', N'IPZ', 2.5, N'OS', N'TA'),
	   (N'Андрій', N'Кульчицький', N'KN', 4.0, N'TI', N'OOP')

GO