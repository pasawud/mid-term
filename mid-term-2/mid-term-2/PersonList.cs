using System;

class PersonList
{
    protected List<Person> personlist;

    public PersonList()
    {
        this.personlist = new List<Person>();
    }

    public void AddNewPerson(Person person)
    {
        this.personlist.Add(person);
    }

    public List<Person> GetPersonList()
    {
        return this.personlist;
    }

}