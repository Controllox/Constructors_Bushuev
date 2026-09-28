namespace Constructors_Bushuev.Classes
{
    /// <summary> Класс студента </summary>
    public class Student
    {
        /// <summary> Имя </summary>
        public string Firstname = "";

        /// <summary> Фамилия </summary>
        public string Lastname = "";

        /// <summary> Отчество </summary>
        public string Surname = "";

        /// <summary> Стипендия </summary>
        public bool Scholarship = false;

        /// <summary> Курс </summary>
        public int Course = 4;

        /// <summary> Конструктор, который принимает в себя ФИО </summary>
        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;
        }

        /// <summary> Конструктор, который принимает ФИО и стипендию </summary>
        public Student(string Firstname, string Lastname, string Surname, bool Scholarship)
            : this(Firstname, Lastname, Surname)
        {
            this.Scholarship = Scholarship;
        }

        /// <summary> Конструктор, который принимает ФИО, стипендию и курс </summary>
        public Student(string Firstname, string Lastname, string Surname, bool Scholarship, int Course)
            : this(Firstname, Lastname, Surname, Scholarship)
        {
            this.Course = Course;
        }

        /// <summary> Метод, который возвращает склеенное ФИО </summary>
        public string GetFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
    }
}