namespace Encapsulation_Lab
{
    using System.Collections.Generic;

    public class Team
    {
        private string _name;
        private List<Person> _firstTeam;
        private List<Person> _reserveTeam;

        public Team(string name)
        {
            this._name = name;
            this._firstTeam = new List<Person>();
            this._reserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this._firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this._reserveTeam.AsReadOnly(); }
        }

        public void AddPerson(Person person)
        {
            if (person.Age < 40)
            {
                _firstTeam.Add(person);
            }
            else
            {
                _reserveTeam.Add(person);
            }
        }

    }
}
