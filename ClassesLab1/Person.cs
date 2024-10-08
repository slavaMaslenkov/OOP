namespace ClassesLab1
{
    /// <summary>
    /// Класс Person, содержащий: имя, фамилию, возраст, пол.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public const int _minAge = 0;

        /// <summary>
        /// Масимальный возраст.
        /// </summary>
        public const int _maxAge = 120;

        /// <summary>
        /// Объект класс Person по умолчанию.
        /// </summary>
        public Person() : this("Неизвестно", "Неизвестно", 18, Gender.Male)
        { }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }

        /// <summary>
        /// Возвращает строку с информацией об объекте/>.
        /// </summary>
        /// <returns>Информация об объекте/>.</returns>
        public string GetInfo()
        {
            return $"Имя: {Name}\tФамилия: {Surname}" +
                    $"\tВозраст: {Age}\tПол: {Gender}\n";
        }

        /// <summary>
        /// Создает рандомный объект класса Person/>.
        /// </summary>
        /// <returns>ОБъект класса Person />.</returns>
        public static Person GetRandomPerson()
        {
            Random rnd = new Random();
            string[] names = { "Катя", "Оля", "Наташа", "Света", "Галя", "Слава", "Эдик", "Вова", "Даня", "Коля" };
            string[] surnames = { "Катяшкина", "Олечкина", "Наташечкина", "Светова", "Галова", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };

            int namesIndex = rnd.Next(names.Length - 1);

            Person randomPerson = new Person();
            randomPerson.Age = rnd.Next(Person._minAge, Person._maxAge);

            if (namesIndex < names.Length * 0.5)
            {
                randomPerson.Name = names[namesIndex];
                randomPerson.Surname = surnames[namesIndex];
                randomPerson.Gender = Gender.Female;
            }
            else
            {
                randomPerson.Name = names[namesIndex];
                randomPerson.Surname = surnames[namesIndex];
                randomPerson.Gender = Gender.Male;
            }

            return randomPerson;
        }

    }
}