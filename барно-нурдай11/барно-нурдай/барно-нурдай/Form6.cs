using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace барно_нурдай
{
    public partial class Form6 : Form
    {
        class Question
        {
            public string Text { get; set; }
            public string[] Options { get; set; } = new string[4];
            public char CorrectAnswer { get; set; } // 'A', 'B', 'C', 'D'
        }

        List<Question> questions = new List<Question>();
        int currentIndex = 0;
        Dictionary<int, char> userAnswers = new Dictionary<int, char>(); // Хранит ответы пользователя
        Stopwatch stopwatch = new Stopwatch();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form6()
        {
            InitializeComponent();
            InitializeQuestions();
            SetupTimer();
            ShowQuestion(0);
        }

        private void InitializeQuestions()
        
        
        {
            string[][] questionData = new string[][]
            {
                new[] {"Класс (Class)", "Шаблон для создания объектов с общими свойствами и методами.", "Только набор методов", "Тип данных без методов", "Контейнер данных без логики"},
                new[] {"Объект (Object)", "Экземпляр класса, представляющий конкретный экземпляр структуры данных.", "Просто переменная", "Программа", "Контейнер для методов"},
                new[] {"Инкапсуляция (Encapsulation)", "Сокрытие внутреннего состояния объекта и управление доступом к его данным.", "Только сокрытие методов", "Только защита данных", "Полное управление памятью"},
                new[] {"Наследование (Inheritance)", "Способ создания новых классов на основе уже существующих.", "Создание новых методов", "Создание копий объектов", "Добавление методов в интерфейс"},
                new[] {"Полиморфизм (Polymorphism)", "Способность объектов с одинаковым интерфейсом иметь разное поведение.", "Переопределение только методов", "Только наследование", "Только инкапсуляция"},
                new[] {"Абстракция (Abstraction)", "Выделение общих характеристик объектов для упрощения модели данных.", "Скрытие методов", "Только защита данных", "Полное исключение данных"},
                new[] {"Интерфейс (Interface)", "Контракт, определяющий набор методов, которые должны быть реализованы.", "Группа переменных", "Набор классов", "Просто методы"},
                new[] {"Абстрактный класс (Abstract class)", "Класс, который не может быть инстанцирован напрямую, только через наследование.", "Класс с открытыми полями", "Класс без методов", "Класс без данных"},
                new[] {"Метод (Method)", "Функция, определённая в классе, описывающая поведение объекта.", "Просто переменная", "Поле класса", "Только статический блок"},
                new[] {"Поле (Field)", "Переменная, определённая внутри класса для хранения данных объекта.", "Только метод", "Только свойство", "Только константа"},
                new[] {"Свойство (Property)", "Механизм для доступа к полям с использованием get и set методов.", "Только методы", "Только поля", "Только конструкторы"},
                new[] {"Конструктор (Constructor)", "Метод, вызываемый при создании объекта для инициализации его данных.", "Только метод", "Только свойство", "Только переменная"},
                new[] {"Деструктор (Destructor)", "Метод, вызываемый перед удалением объекта сборщиком мусора.", "Просто метод", "Метод класса", "Метод интерфейса"},
                new[] {"Модификаторы доступа (Access Modifiers)", "Определяют уровень доступа к членам класса.", "Просто методы", "Просто свойства", "Просто поля"},
                new[] {"Перегрузка методов (Method Overloading)", "Определение методов с одинаковым именем, но разными параметрами.", "Только переопределение", "Только наследование", "Только инкапсуляция"},
                new[] {"Переопределение методов (Method Overriding)", "Изменение реализации метода базового класса в производном классе.", "Только добавление методов", "Только статические методы", "Только абстрактные методы"},
                new[] {"Ключевое слово this", "Ссылка на текущий экземпляр объекта в классе.", "Ссылка на базовый класс", "Ссылка на статический метод", "Ссылка на другую переменную"},
                new[] {"Ключевое слово base", "Используется для вызова методов и конструкторов базового класса.", "Используется для вызова полей", "Используется для статических методов", "Используется для переопределения методов"},
                new[] {"Статический член (Static member)", "Член класса, который принадлежит классу, а не экземплярам.", "Только методы", "Только поля", "Только переменные"},
                new[] {"sealed-класс", "Класс, от которого нельзя наследоваться.", "Просто интерфейс", "Просто абстрактный класс", "Просто метод"},
                new[] {"virtual/override/new", "Ключевые слова для реализации полиморфизма.", "Ключевые слова для конструкторов", "Ключевые слова для полей", "Ключевые слова для интерфейсов"},
                new[] {"Деструктор (Destructor)", "Метод, вызываемый перед удалением объекта сборщиком мусора.", "Просто метод", "Метод класса", "Метод интерфейса"},
                new[] {"Класс (Class)", "Шаблон для создания объектов с общими свойствами и методами.", "Только набор методов", "Тип данных без методов", "Контейнер данных без логики"},
                new[] {"Интерфейс (Interface)", "Контракт, определяющий набор методов, которые должны быть реализованы.", "Группа переменных", "Набор классов", "Просто методы"},
                new[] {"Метод-расширение (Extension method)", "Метод, добавляющий функциональность существующему типу.", "Метод класса", "Метод интерфейса", "Метод структуры"},
                new[] {"Метод-расширение (Extension method)", "Метод, добавляющий функционал к существующему типу без изменения его исходного кода.", "Просто метод", "Просто функция", "Просто переменная"},
                new[] {"Частичный класс (Partial class)", "Класс, который можно разбить на несколько файлов.", "Класс, который нельзя унаследовать", "Класс без методов", "Класс без полей"},
                new[] {"Вложенный класс (Nested class)", "Класс, определённый внутри другого класса.", "Метод внутри класса", "Свойство класса", "Поле класса"},
                new[] {"Generic-класс", "Класс, принимающий параметры типа.", "Класс без методов", "Класс без полей", "Класс без конструктора"},
                new[] {"Метод-расширение (Extension method)", "Метод, добавляющий функциональность существующему типу.", "Метод класса", "Метод интерфейса", "Метод структуры"}
            };

            foreach (var q in questionData)
            {
                questions.Add(new Question
                {
                    Text = q[0],
                    Options = new[] { q[1], q[2], q[3], q[4] },
                    CorrectAnswer = 'A'
                });
            }
        }
        private void SetupTimer()
        {
            timer.Interval = 1000; // 1 секунда
            timer.Tick += Timer_Tick;
            stopwatch.Start();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = stopwatch.Elapsed;
            TimeSpan remaining = TimeSpan.FromMinutes(30) - elapsed;
            if (remaining <= TimeSpan.Zero)
            {
                timer.Stop();
                MessageBox.Show("Время вышло! Тест завершён.");
                ShowResult();
                return;
            }
            label1.Text = $"Осталось времени: {remaining.Minutes:D2}:{remaining.Seconds:D2}";
        }

        private void ShowQuestion(int index)
        {
            if (index < 0 || index >= questions.Count) return;

            currentIndex = index;
            var q = questions[index];

            label2.Text = $"Вопрос {index + 1}: {q.Text}";
            radioButton1.Text = q.Options[0];
            radioButton2.Text = q.Options[1];
            radioButton3.Text = q.Options[2];
            radioButton4.Text = q.Options[3];

            // Сброс выбора
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            // Если уже отвечали — показать ответ
            if (userAnswers.ContainsKey(index))
            {
                char ans = userAnswers[index];
                switch (ans)
                {
                    case 'A': radioButton1.Checked = true; break;
                    case 'B': radioButton2.Checked = true; break;
                    case 'C': radioButton3.Checked = true; break;
                    case 'D': radioButton4.Checked = true; break;
                }
            }

            UpdateUserAnswersList();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            button1.Enabled = currentIndex < questions.Count - 1; // Далее
            button2.Enabled = currentIndex > 0; // Назад
        }

        private void UpdateUserAnswersList()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < questions.Count; i++)
            {
                string ans = userAnswers.ContainsKey(i) ? userAnswers[i].ToString() : "-";
                listBox1.Items.Add($"Вопрос {i + 1}: Ответ: {ans}");
            }
        }

        private void SaveCurrentAnswer()
        {
            if (radioButton1.Checked) userAnswers[currentIndex] = 'A';
            else if (radioButton2.Checked) userAnswers[currentIndex] = 'B';
            else if (radioButton3.Checked) userAnswers[currentIndex] = 'C';
            else if (radioButton4.Checked) userAnswers[currentIndex] = 'D';
            else userAnswers.Remove(currentIndex); // если ничего не выбрано
        }


        private void ShowResult()
        {
            int correctCount = 0;
            int incorrectCount = 0;
            int maxPoints = 30;

            listBox1.Items.Clear(); // Для всех вопросов
            listBox2.Items.Clear(); // Для неправильных вопросов

            // Обработка каждого вопроса
            for (int i = 0; i < questions.Count; i++)
            {
                var q = questions[i];
                string questionText = $"Вопрос {i + 1}: {q.Text}";

                // Если пользователь ответил на вопрос
                if (userAnswers.ContainsKey(i))
                {
                    char userAnswer = userAnswers[i];
                    char correctAnswer = q.CorrectAnswer;
                    string userAnswerText = $"{userAnswer} ({q.Options[userAnswer - 'A']})";
                    string correctAnswerText = $"{correctAnswer} ({q.Options[correctAnswer - 'A']})";

                    // Добавляем в первый ListBox
                    listBox1.Items.Add($"{questionText} - Ваш ответ: {userAnswerText}");

                    // Если ответ неверный, добавляем во второй ListBox
                    if (userAnswer != correctAnswer)
                    {
                        incorrectCount++;
                        listBox2.Items.Add($"{questionText}");
                        listBox2.Items.Add($"Ваш ответ: {userAnswerText}");
                        listBox2.Items.Add($"Правильный ответ: {correctAnswerText}");
                        listBox2.Items.Add(""); // Пустая строка для разделения вопросов
                    }
                    else
                    {
                        correctCount++;
                    }
                }
                else
                {
                    // Если пользователь не выбрал ответ
                    listBox1.Items.Add($"{questionText} - Ответ не выбран");
                }
            }

            // Итоговая статистика
            double percent = (double)correctCount / questions.Count * 100;
            double points = maxPoints * percent / 100;
            int grade = points >= 18 ? 5 : points >= 14 ? 4 : points >= 10 ? 3 : 2;

            listBox2.Items.Add("=== Итог ===");
            listBox2.Items.Add($"Правильных ответов: {correctCount} из {questions.Count}");
            listBox2.Items.Add($"Неправильных ответов: {incorrectCount}");
            listBox2.Items.Add($"Процент выполнения: {percent:F2}%");
            listBox2.Items.Add($"Баллы: {points:F1} из {maxPoints}");
            listBox2.Items.Add($"Оценка: {grade}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            if (currentIndex < questions.Count - 1)
            {
                ShowQuestion(currentIndex + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            if (currentIndex > 0)
            {
                ShowQuestion(currentIndex - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            timer.Stop();
            stopwatch.Stop();
            ShowResult();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            UpdateUserAnswersList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            UpdateUserAnswersList();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            UpdateUserAnswersList();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            UpdateUserAnswersList();
        }
    }
}