string StudentName = "Sophia Johson";

int courseEnglishGrade = 4;
int courseAlgebraGrade = 3;
int courseBiologyGrade = 3;
int computerScienceGrade =  3;
int psychologyGrade = 4;


int chforEnglish = 3;
int chForAlgebra = 3;
int chBiology = 4;
int chcomputerscience =4;
int chpsychology = 3;

decimal totalNumberofCredithours = chforEnglish + chForAlgebra + chBiology + chcomputerscience + chpsychology;


decimal multiplicativeEnglishvalue = courseEnglishGrade * chforEnglish;
decimal multiplicativeAlgebravalue = courseAlgebraGrade * chForAlgebra;
decimal multiplicativeBiologyvalue = courseBiologyGrade * chBiology;
decimal multiplicativeComputerSciencevalue = computerScienceGrade * chcomputerscience;
decimal multipicativepsychologyvalue = psychologyGrade * chpsychology;

decimal Overallresult  = multiplicativeEnglishvalue + multiplicativeAlgebravalue + multiplicativeBiologyvalue + multiplicativeComputerSciencevalue + multipicativepsychologyvalue;




decimal finalGPA =  Overallresult/totalNumberofCredithours ;

Console.WriteLine($"Student: {StudentName}");

Console.WriteLine($"Course \t\t Grade \t Credit Hours");
Console.WriteLine($"English101 \t {courseEnglishGrade} \t\t {chforEnglish}");
Console.WriteLine($"Algebra101 \t {courseAlgebraGrade} \t\t {chForAlgebra}");
Console.WriteLine($"Biology101 \t {courseBiologyGrade} \t\t {chBiology}");
Console.WriteLine($"Computer Science  \t {computerScienceGrade} \t\t {chcomputerscience}");


Console.WriteLine($"finalGPA : {finalGPA}");

