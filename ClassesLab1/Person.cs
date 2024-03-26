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
        /// Возраст.
        /// </summary>
        private int _age;

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
    }
}