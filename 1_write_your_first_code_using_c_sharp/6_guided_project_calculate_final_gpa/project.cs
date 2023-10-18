string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int totalCredits = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int course1FinalGrade = course1Grade * course1Credit;
int course2FinalGrade = course2Grade * course2Credit;
int course3FinalGrade = course3Grade * course3Credit;
int course4FinalGrade = course4Grade * course4Credit;
int course5FinalGrade = course5Grade * course5Credit;

int gradesSum = course1FinalGrade + course2FinalGrade + course3FinalGrade + course4FinalGrade + course5FinalGrade;

decimal finalGpa = (decimal)gradesSum / totalCredits;

Console.WriteLine($"Student: {studentName}\n");

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

int firstDigit = (int) (finalGpa * 10) % 10;
int secondDigit = (int) (finalGpa * 100) % 10;

Console.Write("\nFinal GPA:\t\t\t" + (int)finalGpa + '.' + firstDigit + secondDigit);