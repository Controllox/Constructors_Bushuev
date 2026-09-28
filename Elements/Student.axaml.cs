using Avalonia.Controls;
using Constructors_Bushuev.Classes;

namespace Constructors_Bushuev.Elements
{
    /// <summary> Логика взаимодействия для Student.axaml </summary>
    public partial class Student : UserControl
    {
        /// <summary> Конструктор элемента </summary>
        public Student(Classes.Student student)
        {
            InitializeComponent();

            // В фамилию присваиваем фамилию, полученную из Lastname + Firstname + Surname
            tb_fio.Text = student.GetFIO();

            // В стипендию присваиваем, получает её студент или нет
            tb_scholarship.Text = student.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";

            // В курс присваиваем номер курса
            tb_course.Text = $"Курс: {student.Course}";
        }
    }
}