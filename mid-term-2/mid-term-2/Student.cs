using System;

class Student : Person
{
    public string studentID;

    public Student(string username, string password, string studentID) : base(username, password)
    {
        this.studentID = studentID;

    }

    public string GetStudentID()
    {
        return this.studentID;
    }
}