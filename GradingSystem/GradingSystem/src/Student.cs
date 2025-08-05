using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradingSystem.src
{
    public class Student
    {
        public int Id;
        public string FullName;
        public int Score;

        public Student(int id, string fullName, int score)
        {
            Id = id;
            FullName = fullName;
            Score = score;
        }
        public string GetGrade()
        {
            if (Score >= 80)
            {
                return "A";
            }
            else if (Score >= 70)
            {
                return "B";
            }
            else if (Score >= 60)
            {
                return "C";
            }
            else if (Score >= 50)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}