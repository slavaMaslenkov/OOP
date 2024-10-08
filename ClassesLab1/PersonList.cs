using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesLab1
{
    /// <summary>
    /// Класс PersonList, описывающий абстракцию списка,
    /// содержащего объекты класса Person.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Создание списка объектов класса Person.
        /// </summary>
        List<Person> _personList = new List<Person>();

        /// <summary>
        /// Метод добавления объекта типа Person в список personList.
        /// </summary>
        /// <param name="person">Объект класса Person</param>
        public void AddPerson(Person person)
        {
            _personList.Add(person);
        }

        /// <summary>
        /// Метод удаления объекта типа Person в списке personList.
        /// </summary>
        /// <param name="person">Объект класса Person</param>
        public void RemovePerson(Person person)
        {
            _personList.Remove(person);
        }
        
        /// <summary>
        /// Метод удаление объекта по индексу.
        /// </summary>
        /// <param name="index">Индекс объекта.</param>
        /// <returns>Объект класса Person.</returns>
        public void RemovePersonByIndex(int index)
        {
            CheckIndexAvailability(index);
            _personList.RemoveAt(index);
        }

        /// <summary>
        /// Метод получения объекта из списка по индексу.
        /// </summary>
        /// <param name="index">Индекс объекта.</param>
        /// <returns>Объект класса Person.</returns>
        public Person GetPersonByIndex(int index)
        {
            CheckIndexAvailability(index);
            return _personList[index];
        }

        /// <summary>
        /// Метод получения индекса объекта, если тот имеется в списке.
        /// </summary>
        /// <param name="Person">Имя объекта.</param>
        /// <returns>Индекс объекта.</returns>
        public int GetIndexByPerson(Person person)
        {
            if (_personList.Contains(person))
            {
                 return _personList.IndexOf(person);
            }
            else 
            {
                throw new InvalidOperationException("Человека нет в списке.");
            }
        }

        /// <summary>
        /// Метод удаления всех объектов в списке.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public void ClearPersonList()
        {
             _personList.Clear();
        }

        /// <summary>
        /// Получает количество записей в листе.
        /// </summary>
        public int CountOfList()
        {
             return _personList.Count();
        }

        private void CheckIndexAvailability(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException($"Введено число" +
                    $" меньше нуля");
            }
            if (index > _personList.Count - 1)
            {
                throw new ArgumentOutOfRangeException($"В списке нет объекта " +
                    $"под номером {index}, в списке " +
                    $"всего {_personList.Count} объектов");
            }
        }

        /// <summary>
        /// Возвращает строку с информацией об объектах в списке/>.
        /// </summary>
        /// <returns>Информация об объектах/>.</returns>
        public string PersonInfo()
        {
            string list = "";

            for (int index = 0; index < _personList.Count; index++)
            {
                list += (_personList[index].GetInfo() + new string('_', 100) + "\n");
            }

            return list;
        }
    }
}
