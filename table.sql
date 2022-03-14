CREATE TABLE professorOffice(
    title TEXT,
    officeId INTEGER PRIMARY KEY,
    descrip TEXT,
    email TEXT,
    
    
);

CREATE TABLE classroom(
    title TEXT,
    classroomId INTEGER PRIMARY KEY,
    descrip TEXT,
    usage TEXT,
    
);

CREATE TABLE roomTarget(
    roomId INTEGER FOREIGN KEY KEY REFERENCES classroom(classroomId),
    officeId INTEGER FOREIGN KEY REFERENCES professorOffice(officeId),
);