using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];

            // Initialize the scores for each student
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            int studentNumber = 1, totalStudentsSum = 0, scoreCount = 0;

            // Print the scores of each student using loops

            foreach (var student in studentScores)
            {
                int eachStudentsSum = 0;
                Console.WriteLine($"Student{studentNumber}:");
                foreach (var score in student)
                {
                    Console.WriteLine($"{score}");
                    eachStudentsSum += score;
                    scoreCount += 1;
                }
                totalStudentsSum += eachStudentsSum;
                //calculate average of each student
                int eachStudentAverage = eachStudentsSum / studentScores[studentNumber - 1].Length;
                Console.WriteLine($"\nAverage of student{studentNumber}:{eachStudentAverage}\n");
                studentNumber++;
            }
            //calculate the average of total students
            int totalStudentAverage = totalStudentsSum / scoreCount;
            Console.WriteLine($"\nAverage of all students:{totalStudentAverage}");
            Console.ReadLine();

        }


    }
            
}