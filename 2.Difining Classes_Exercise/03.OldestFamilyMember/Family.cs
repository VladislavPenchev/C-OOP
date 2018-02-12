
using System.Collections.Generic;

public class Family
    {

    private List<Person> list;

    public void AddMember(Person member)
    {
        list.Add(member);
    }

    public Person GetOldestMember()
    {
        list.Sort();

        return list[list.Count - 1];
    }

    }

