// initialize variables - graded assignments 
int currentAssignments = 5;

int[,] studentScores = {{0, 92, 86, 87, 98, 100}, {1, 92, 89, 81, 96, 90}, {2, 90, 85, 87, 98, 68}, {3, 90, 95, 87, 88, 96}};

// nested for loops to iterate through multi-dimensional array.
static int ScoreSum(int studentID, int[,] studentScores) {
    int scoreSum = 0;
    for (int i = 0; i < studentScores.GetLength(0); i++) {
        if (i == studentID) {
            for (int j = 0; j < studentScores.GetLength(1); j++) {
                if (j == 0){
                    continue;
                }
                else {
                    scoreSum += studentScores[i,j];
                }
            }
            return scoreSum;
        }
    }
    return 0;
}

static string GetGrade(int grade) {
    if (grade >= 97 && grade <= 100) {
        return "A+";
    }
    if (grade >= 93 && grade < 97) {
        return "A";
    }
    if (grade >= 90 && grade < 93) {
        return "A-";
    }
    if (grade >= 87 && grade < 90 ) {
        return "B+";
    }
    if (grade >= 83 && grade < 87) {
        return "B";
    }
    if (grade >= 80 && grade < 83) {
        return "B-";
    } 
    if (grade >= 77 && grade <= 80) {
        return "C+";
    }
    if (grade >= 73 && grade < 77) {
        return "C";
    }
    if (grade >= 70 && grade < 73) {
        return "C-";
    }
    if (grade >= 67 && grade < 70) {
        return "D+";
    }
    if (grade >= 63 && grade < 67) {
        return "D";
    }
    if (grade >= 60 && grade < 63) {
        return "D-";
    }
    if (grade >= 0 && grade < 60) {
        return "F";
    }
    return "Invalid Grade.";
}

int [,] studentGrades ={{0,0}, {1,0}, {2,0}, {3,0}};
for (int i =0; i < studentGrades.GetLength(0); i++) {
    studentGrades[i,1] = (ScoreSum(studentGrades[i,0], studentScores) / currentAssignments);
}

// Create Dictionary of Students and student IDs, iterate through dictionary to get names and grades
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + (studentGrades[0,1]) + "\t" + (GetGrade(studentGrades[0,1])));
Console.WriteLine("Andrew:\t\t" + (studentGrades[1,1]) + "\t" +  (GetGrade(studentGrades[1,1])));
Console.WriteLine("Emma:\t\t" + (studentGrades[2,1]) + "\t" + (GetGrade(studentGrades[2,1])));
Console.WriteLine("Logan:\t\t" + (studentGrades[3,1]) + "\t" + (GetGrade(studentGrades[3,1])));

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
