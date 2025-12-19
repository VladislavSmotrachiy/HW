 public class Program
{
   public static void Main()
{
    Student stud = new Student();
    Console.WriteLine(stud.Password);

    GriffindorStudent grifStud = new GriffindorStudent();
    grifStud.BreakRules();
    Console.WriteLine(grifStud.Password);
    Student student2 = (Student)grifStud;
    Console.WriteLine(student2.Password);
} 
}




