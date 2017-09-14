using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EducationLibrary;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LINQLesson {
	class Program {
		static void Main(string[] args) {
			var students = StudentCollection.Select();

			//to get sutdents with GPA >= 3.5 WITHOUT LINQ
			StudentCollection DeansListStudents = new StudentCollection();
			foreach (var s in students) {
				if (s.GPA >= 3.5 && s.SAT > 1400) {
					DeansListStudents.Add(s);
				}
			}

			// WITH LINQ (lambda syntax)
			var TopStudents = students.Where(stud => stud.GPA >= 3.5 && stud.SAT > 1400).OrderByDescending(s => s.GPA);
			


			foreach (var student in TopStudents) {
				Debug.WriteLine($"{student.FirstName}{student.LastName} GPA is {student.GPA}");
			}
		}
	}
}
