// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tGrade");

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

foreach(string student in studentNames) 
{
    int[] studentScores;

    if (student == "Sophia")
        studentScores = sophiaScores;
    else if (student == "Andrew")
        studentScores = andrewScores;
    else if (student == "Emma")
        studentScores = emmaScores;
    else if (student == "Logan")
        studentScores = loganScores;
    else if (student == "Becky")
        studentScores = beckyScores;
    else if (student == "Chris")
        studentScores = chrisScores;
    else if (student == "Eric")
        studentScores = ericScores;
    else if (student == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int gradeSum = 0;
    int gradesCount = 0;
    foreach(int grade in studentScores)
    {
        if (gradesCount >= 5) 
        {
            gradeSum += (int)(grade*0.1);
        }
        else
        {
            gradeSum += grade;
        }
        gradesCount ++;
    }

    decimal finalGrade = (decimal)gradeSum / currentAssignments;

    string gradeLetter;
    if (finalGrade >= 97)
    {
        gradeLetter = "A+";
    }
    else if (finalGrade >= 93)
    {
        gradeLetter = "A";
    }
    else if (finalGrade >= 90)
    {
        gradeLetter = "A-";
    }
    else if (finalGrade >= 87)
    {
        gradeLetter = "B+";
    }
    else if (finalGrade >= 83)
    {
        gradeLetter = "B";
    }
    else if (finalGrade >= 80)
    {
        gradeLetter = "B-";
    }
    else if (finalGrade >= 77)
    {
        gradeLetter = "C+";
    }
    else if (finalGrade >= 73)
    {
        gradeLetter = "C";
    }
    else if (finalGrade >= 70)
    {
        gradeLetter = "C-";
    }
    else if (finalGrade >= 67)
    {
        gradeLetter = "D+";
    }
    else if (finalGrade >= 63)
    {
        gradeLetter = "D";
    }
    else if (finalGrade >= 60)
    {
        gradeLetter = "D-";
    }
    else
    {
        gradeLetter = "F";
    }

    Console.WriteLine($"{student}\t\t{finalGrade}\t{gradeLetter}");
}