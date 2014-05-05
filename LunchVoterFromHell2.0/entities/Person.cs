namespace Entities
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Group Group { get; set; }
    }
}