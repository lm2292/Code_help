CREATE TABLE student (
	student_id INT IDENTITY,
	fullname VARCHAR(15),
	major VARCHAR(15),
	PRIMARY KEY(student_id)
);

INSERT INTO student (fullname, major) VALUES('Lukas Macha', 'Engineering')
INSERT INTO student (fullname, major) VALUES('Jan Macha', 'Sports')
INSERT INTO student (fullname, major) VALUES('Tomas Novak', 'Sociology')
INSERT INTO student (fullname, major) VALUES('Jane Flee', 'Biology')

SELECT * FROM student;

UPDATE student 
SET major = 'Bio'
WHERE major = 'Biology';

UPDATE student
SET major = 'Maths', fullname = 'Peter Parker' 
WHERE major = 'Eng' OR major = 'Sociology';

UPDATE student
SET major ='undecided';

DELETE FROM student
WHERE student_id = 4;

DELETE FROM student
WHERE fullname = 'Jan Macha' AND major = 'undecided';

SELECT student.fullname, student.major
FROM student
ORDER BY fullname;

SELECT *
FROM student
ORDER BY student_id DESC;

SELECT *
FROM student
ORDER BY major, student_id;

SELECT TOP (2) *
FROM student
ORDER BY student_id DESC

SELECT fullname, major
FROM student
WHERE major = 'Biology' OR major = 'undecided'

SELECT * 
FROM student
WHERE fullname IN ('Lukas Macha', 'Peter Parker') AND student_id >2;

