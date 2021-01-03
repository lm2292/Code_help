CREATE TABLE student (
	student_id INT PRIMARY KEY,
	name VARCHAR(20),
	major VARCHAR(20),
);

DROP TABLE student;

ALTER TABLE student ADD gpa DECIMAL;

ALTER TABLE student DROP COLUMN gpa; 

INSERT INTO student VALUES (5,'Mike', 'Computer Science');

SELECT * FROM student;

INSERT INTO student(student_id, name) VALUES (3,'Claire');

