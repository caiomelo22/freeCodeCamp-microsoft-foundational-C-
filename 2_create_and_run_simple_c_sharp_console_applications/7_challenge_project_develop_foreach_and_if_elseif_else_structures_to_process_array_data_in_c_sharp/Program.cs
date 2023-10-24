// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit");

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
    int extraCreditSum = 0;
    int extraCreditCount = 0;
    int gradesCount = 0;
    foreach(int score in studentScores)
    {
        if (gradesCount >= 5) 
        {
            extraCreditSum += score;
            extraCreditCount ++;
        }
        else
        {
            gradeSum += score;
            gradesCount ++;
        }
    }

    int extraCreditGrade = extraCreditSum / extraCreditCount;
    decimal extraCreditFinal = ((decimal)extraCreditSum / currentAssignments) * 0.1m;
    decimal examGrade = (decimal)gradeSum / currentAssignments;
    decimal finalScore = examGrade + extraCreditFinal;

    string gradeLetter;
    if (finalScore >= 97)
    {
        gradeLetter = "A+";
    }
    else if (finalScore >= 93)
    {
        gradeLetter = "A";
    }
    else if (finalScore >= 90)
    {
        gradeLetter = "A-";
    }
    else if (finalScore >= 87)
    {
        gradeLetter = "B+";
    }
    else if (finalScore >= 83)
    {
        gradeLetter = "B";
    }
    else if (finalScore >= 80)
    {
        gradeLetter = "B-";
    }
    else if (finalScore >= 77)
    {
        gradeLetter = "C+";
    }
    else if (finalScore >= 73)
    {
        gradeLetter = "C";
    }
    else if (finalScore >= 70)
    {
        gradeLetter = "C-";
    }
    else if (finalScore >= 67)
    {
        gradeLetter = "D+";
    }
    else if (finalScore >= 63)
    {
        gradeLetter = "D";
    }
    else if (finalScore >= 60)
    {
        gradeLetter = "D-";
    }
    else
    {
        gradeLetter = "F";
    }

    Console.WriteLine($"{student}\t\t{examGrade}\t\t{finalScore}\t{gradeLetter}\t{extraCreditGrade} ({extraCreditFinal} pts)");
}