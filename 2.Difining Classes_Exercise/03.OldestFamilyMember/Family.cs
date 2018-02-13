
using System;
using System.Collections.Generic;

public class Family
    {

    private List<Person> list;


    public Family()
    {
        this.list = new List<Person>();
    }

    public void AddMember(Person member)
    {
        list.Add(member);
    }

    public Person GetOldestMember()
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i].Age > list[i + 1].Age)
            {
                continue;
            }
            else if (list[i].Age < list[i + 1].Age)
            {
                this.Swap(list, i);
                GetOldestMember();
            }
            else
            {
                //ravni
            }
        }

        

        return list[0];
    }

    private void Swap(List<Person> list,int i)
    {
        Person temp = list[i];
        list[i] = list[i + 1];
        list[i + 1] = temp;
    }

    public void GetAllPersonAfter30()
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i].Age > list[i + 1].Age)
            {
                continue;
            }
            else if (list[i].Age < list[i + 1].Age)
            {
                this.Swap(list, i);
                GetOldestMember();
            }
            else
            {
                //ravni
            }
        }

        foreach (var person in list)
        {
            
            if (person.Age > 30)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
        
    }

}

