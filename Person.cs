namespace HelloOOP
{
    public class Person
    {
        public static int numberOfPeople = 0;

        private string _firstName;

        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _firstName = "<NIEZNANE>";
                }
                _firstName = value; 
            }
        }

        public string lastName;
        public int age;

        public Person(string firstName, string lastName, int age)
        {
            Console.WriteLine("Konstruktor z parametrami");
            
            if (string.IsNullOrWhiteSpace(lastName))
            {
                //throw new ArgumentException(nameof(lastName));
                lastName = "<NIEZNANE>";
            }
            if (age < 0)
            {
                //throw new ArgumentException(nameof(age));
                age = 0;
            }

            SetFirstName(firstName);
            this.lastName = lastName;
            this.age = age;

            numberOfPeople++;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                //throw new ArgumentException(nameof(firstName));
                firstName = "<NIEZNANE>";
            }
            this._firstName = firstName;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"{_firstName} {lastName} is {age} years old.");
        }
    }
}
