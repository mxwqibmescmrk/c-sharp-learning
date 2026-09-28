using System;

// initialize variables - graded assignments 
int examAssignments = 5;


int [] sophiaAssignmentScore = new int[] {90, 86, 87, 98, 100, 94, 90};
int [] andrewAssignmentScore = new int[] {92, 89, 81, 96, 90, 89};
int [] emmaAssignmentScore = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int [] loganAssignmentScore = new int[] {90, 95, 87, 88, 96, 96};
int [] beckyAssignmentScore = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int [] chrisAssignmentScore = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int [] ericAssignmentScore = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int [] gregorAssignmentScore = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string [] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};
int [] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach(string student in studentNames)
{
        
    string currentStudent = student;
    if (currentStudent == "Sophia")
        studentScores = sophiaAssignmentScore;
    else if (currentStudent == "Andrew")
        studentScores = andrewAssignmentScore;
    else if (currentStudent == "Emma")
        studentScores = emmaAssignmentScore;
    else if (currentStudent == "Logan")
        studentScores = loganAssignmentScore;
    else if (currentStudent == "Becky")
        studentScores = beckyAssignmentScore;
    else if (currentStudent == "Chris")
        studentScores = chrisAssignmentScore;
    else if (currentStudent == "Eric")
        studentScores = ericAssignmentScore;
    else if (currentStudent == "Gregor")
        studentScores = gregorAssignmentScore;

    int sumAssignmentsScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    foreach(int score in studentScores)
    {
        gradedAssignments += 1;
        if(gradedAssignments <= examAssignments)
        {
            sumAssignmentsScores += score;
        }
        else
        {
            sumAssignmentsScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentsScores / examAssignments;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    
    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}"); 
    
}

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;



// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// // sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// // andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// // emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// // loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// foreach(int sophia in sophiaAssignmentScore)
// {
//     sophiaSum += sophia;
// }

// sophiaScore = (decimal)sophiaSum / currentAssignments;

// foreach(int andrew in andrewAssignmentScore)
// {
//     andrewSum += andrew;
// }

// andrewScore = (decimal)andrewSum / currentAssignments;

// foreach(int emma in emmaAssignmentScore)
// {
//     emmaSum += emma;
// }

// emmaScore = (decimal)emmaSum / currentAssignments;

// foreach(int logan in loganAssignmentScore)
// {
//     loganSum += logan;
// }

// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
