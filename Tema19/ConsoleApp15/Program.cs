using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Класс, представляющий программу для обработки оценок студентов.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        string marksFileName = "mark.txt";
        string subjectsFileName = "Subjects.txt";

        List<Student> students = ReadStudentsFromFile(marksFileName);
        List<string> subjects = ReadSubjectsFromFile(subjectsFileName);

        Console.WriteLine("Отличники:");
        DisplayExcellentStudents(students);

        Dictionary<string, double> averageScores = CalculateAverageScores(students);

        Console.WriteLine("\nСредняя оценка класса по каждому предмету:");
        foreach (var kvp in averageScores)
        {
            Console.WriteLine($"{subjects[int.Parse(kvp.Key) - 1]}: {kvp.Value}");
        }

        string outputFileName = "average_scores.txt";
        WriteStudentsAverageToFile(students, outputFileName);
        Console.WriteLine($"\nДанные о средних баллах студентов записаны в файл '{outputFileName}'.");
    }

    /// <summary>
    /// Класс, представляющий студента.
    /// </summary>
    class Student
    {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Оценки студента.
        /// </summary>
        public List<int> Marks { get; set; }

        /// <summary>
        /// Средний балл студента.
        /// </summary>
        public double AverageScore => Marks.Average();
    }

    /// <summary>
    /// Чтение информации о студентах из файла.
    /// </summary>
    /// <param name="fileName">Имя файла с оценками студентов.</param>
    /// <returns>Список студентов.</returns>
    static List<Student> ReadStudentsFromFile(string fileName)
    {
        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(' ');
                Student student = new Student
                {
                    Name = parts[0],
                    Marks = parts.Skip(1).Select(int.Parse).ToList()
                };
                students.Add(student);
            }
        }

        return students;
    }

    /// <summary>
    /// Чтение списка предметов из файла.
    /// </summary>
    /// <param name="fileName">Имя файла с предметами.</param>
    /// <returns>Список предметов.</returns>
    static List<string> ReadSubjectsFromFile(string fileName)
    {
        List<string> subjects = new List<string>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                subjects.Add(line);
            }
        }

        return subjects;
    }

    /// <summary>
    /// Отображение студентов с отличными оценками.
    /// </summary>
    /// <param name="students">Список студентов.</param>
    static void DisplayExcellentStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            if (student.Marks.All(mark => mark >= 9))
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    /// <summary>
    /// Вычисление средних оценок по каждому предмету.
    /// </summary>
    /// <param name="students">Список студентов.</param>
    /// <returns>Словарь средних оценок по предметам.</returns>
    static Dictionary<string, double> CalculateAverageScores(List<Student> students)
    {
        Dictionary<string, List<int>> subjectScores = new Dictionary<string, List<int>>();

        foreach (var student in students)
        {
            for (int i = 0; i < student.Marks.Count; i++)
            {
                string subjectIndex = (i + 1).ToString();
                if (!subjectScores.ContainsKey(subjectIndex))
                {
                    subjectScores[subjectIndex] = new List<int>();
                }
                subjectScores[subjectIndex].Add(student.Marks[i]);
            }
        }

        Dictionary<string, double> averageScores = new Dictionary<string, double>();

        foreach (var kvp in subjectScores)
        {
            averageScores[kvp.Key] = kvp.Value.Average();
        }

        return averageScores;
    }

    /// <summary>
    /// Запись данных о средних баллах студентов в файл.
    /// </summary>
    /// <param name="students">Список студентов.</param>
    /// <param name="fileName">Имя файла для записи данных.</param>
    static void WriteStudentsAverageToFile(List<Student> students, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var student in students.OrderByDescending(s => s.AverageScore))
            {
                writer.WriteLine($"{student.Name}: {student.AverageScore}");
            }
        }
    }
}
