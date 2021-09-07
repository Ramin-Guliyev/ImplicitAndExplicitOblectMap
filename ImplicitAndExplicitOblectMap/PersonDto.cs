namespace ImplicitAndExplicitOblectMap
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public static implicit operator PersonDto(Person person)
        {
            return new PersonDto
            {
                Id = person.Id,
                Name = person.Name,
                Lastname = person.Lastname
            };
        }
        public static implicit operator Person(PersonDto person)
        {
            return new Person
            {
                Id = person.Id,
                Name = person.Name,
                Lastname = person.Lastname,
                IsActive=false
            };
        }
    }
}
