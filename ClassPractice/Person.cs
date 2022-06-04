namespace ClassPractice
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        private int id;
        private static List<Person> persons = new List<Person>();

        public void Introduce()
        {
            Console.WriteLine("Hello " + firstName + " " + lastName);
        }
    }
}