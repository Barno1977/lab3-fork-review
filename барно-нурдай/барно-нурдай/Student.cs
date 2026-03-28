using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace барно_нурдай
{
    internal class Student
    {
        public string ФИО { get; set; }
        public string Группа { get; set; }
        public string Оценки { get; set; }

        public bool HasOnlyGoodGrades()
        {
            if (string.IsNullOrWhiteSpace(Оценки))
                return false;

            try
            {
                var grades = Оценки.Split(',')
                                         .Select(g => int.Parse(g.Trim()))
                                         .ToList();

                return grades.Any(g => g == 4 || g == 5);
            }
            catch
            {
                return false;
            }
        }
    }
}
