
using System.Collections.Generic;

public class Person
    {
    private string _name;

    private int _age;

    private List<BankAccount> _accounts;

    public Person(string name,int age)
        :this(name,age,new List<BankAccount>())
    {
    }
    public Person(string name,int age, List<BankAccount> account)
    {
        this._name = name;
        this._age = age;
        this._accounts = account;
    }

    public List<BankAccount> Accounts{ get; set; }

    public double GetBalance()
    {
        return 2.0;
    }


    }
