namespace Entities
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public Group Group { get; set; }
    }
}