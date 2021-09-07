using System;

namespace ImplicitAndExplicitOblectMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personDto =new PersonDto
            {
                Id = 1,
                Name = "Ramin",
                Lastname = "Guliyev"
            };

            Console.WriteLine(personDto.Name);
        }
    }
}
