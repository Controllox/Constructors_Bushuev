using System.Collections.Generic;
using Avalonia.Controls;
using Constructors_Bushuev.Classes;
using Constructors_Bushuev.Elements;

namespace Constructors_Bushuev
{
    /// <summary> Логика взаимодействия для MainWindow.axaml </summary>
    public partial class MainWindow : Window
    {
        /// <summary> Список студентов, которых будем отображать </summary>
        public List<Classes.Student> AllStudent = Classes.RepoStudents.AllStudent();

        /// <summary> Количество записей для разовой прогрузки </summary>
        public int Count = 10;

        /// <summary> Шаг, на котором находится пользователь </summary>
        public int Step = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Создание студентов
            CreateStudent(Step, Count);
        }

        /// <summary> Метод создания студентов </summary>
        public void CreateStudent(int Step, int Count)
        {
            // Перебираем студентов с шага на котором остановились, до шага + кол-во записей
            for (int iStudent = Step; iStudent < Step + Count; iStudent++)
            {
                // Если индекс не вышел за рамки
                if (iStudent < AllStudent.Count)
                {
                    // Добавляем в интерфейс пользовательский элемент со студентом
                    parent.Children.Add(new Elements.Student(AllStudent[iStudent]));
                }
            }

            // Увеличиваем шаг на кол-во записей
            this.Step += Count;
        }

        /// <summary> Пролистывание списка </summary>
        private void ScrollViewer_ScrollChanged(object? sender, ScrollChangedEventArgs e)
        {
            // Получаем элемент прокрутки
            ScrollViewer? scroll = sender as ScrollViewer;
            if (scroll == null) return;

            // Получаем высоту списка с элементами
            double ParentHeight = parent.ActualHeight;

            // Получаем высоту окна - 20 пикселей отступ
            double WindowHeight = scroll.ActualHeight - 20;

            // Получаем дельту высоты, на которую может сместиться пользователь
            double DeltaHeight = ParentHeight - WindowHeight;

            // Если высота, на которую может сместиться пользователь минус высота на которую спустился < 140
            if (DeltaHeight - scroll.Offset.Y < 140)
            {
                // Создаём новые
                CreateStudent(Step, Count);
            }
        }
    }
}