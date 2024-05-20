// Definindo o nome do estudante
string studentName = "Sophia Johnson";

// Definindo os nomes dos cursos
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// Definindo os créditos de cada curso
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Definindo valores das notas A e B
int gradeA = 4;
int gradeB = 3;

// Atribuindo as notas recebidas em cada curso
int course1Grade = gradeA; // Nota A em English 101
int course2Grade = gradeB; // Nota B em Algebra 101
int course3Grade = gradeB; // Nota B em Biology 101
int course4Grade = gradeB; // Nota B em Computer Science I
int course5Grade = gradeA; // Nota A em Psychology 101

// Calculando o total de horas de crédito
int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Calculando o total de pontos de nota
int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// Calculando o GPA (Grade Point Average)
decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;

// Extraindo os dígitos principais do GPA para formatação
int leadingDigit = (int) gradePointAverage; // Parte inteira do GPA
int firstDigit = (int) (gradePointAverage * 10 ) % 10; // Primeiro dígito decimal
int secondDigit = (int) (gradePointAverage * 100 ) % 10; // Segundo dígito decimal

// Exibe o nome do aluno e uma linha em branco para separação
Console.WriteLine($"Student: {studentName}\n");

// Exibe o cabeçalho da tabela com as colunas "Curso", "Nota" e "Horas de Crédito"
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name,-30}{course1Grade,-10}{course1Credit,-15}");
Console.WriteLine($"{course2Name,-30}{course2Grade,-10}{course2Credit,-15}");
Console.WriteLine($"{course3Name,-30}{course3Grade,-10}{course3Credit,-15}");
Console.WriteLine($"{course4Name,-30}{course4Grade,-10}{course4Credit,-15}");
Console.WriteLine($"{course5Name,-30}{course5Grade,-10}{course5Credit,-15}");