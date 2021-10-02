using System;

class Person
{
    public string username;

    protected string password;

    public Person(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public string GetName()
    {
        return this.username;
    }

    public string GetPassword()
    {
        return this.password;
    }
}