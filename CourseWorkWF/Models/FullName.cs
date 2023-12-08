using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class FullName : IFullName
    {
        private string _name;
        private string _surname;

        public string Name 
        {
            get { return _name; }
            set { if (value == null || value == "") throw new Exception("Имя не может быть пустым"); _name = value; }
        }
        public string Surname 
        {
            get { return _surname; }
            set { if (value == null || value == "") throw new Exception("Фамилия не может быть пустой"); _surname = value; }
        }
        public string? Patronymic { get; set; }
        public FullName(string name, string surname, string? patronymic) 
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;


        }
}
}
