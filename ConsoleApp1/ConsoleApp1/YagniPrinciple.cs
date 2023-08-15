namespace ConsoleApp1
{
    public class Author
    {
        private string _firstName;
        private string _lastName;

        public Author(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string GetAuthorName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
