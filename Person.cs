namespace BasicCodingKata
{
    public class Person
    {
        // class fields
        public string Name { get; set; }
        public string HairColour { get; set; }
        
        
        // constructors
        public Person(string name, string hairColour)
        {
            Name = name;
            HairColour = hairColour;
        }
    }
}