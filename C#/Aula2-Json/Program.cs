using System;
using System.Collections.Generic;
using Entities;
using Newtonsoft.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string jsonFilePath = "C:/Labs/Estrutura e Algoritmos/C#/Aula2-Json/bin/file.json";

                string jsonContent = File.ReadAllText(jsonFilePath);

                List<Course> courses = JsonConvert.DeserializeObject<List<Course>>(jsonContent);

                foreach (Course course in courses)
                {
                    Console.WriteLine($"Couse {course.Id}: - {course.Title}");

                    foreach (Lesson lesson in course.Lessons)
                    {
                        Console.WriteLine($"    id: {lesson.Id}");
                        Console.WriteLine($"    title: {lesson.Title}");
                        Console.WriteLine($"    media: {lesson.Media}");
                        Console.WriteLine($"    timeStamp: {lesson.TimeStamp}");
                    }
                    System.Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}