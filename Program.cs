namespace HomeWork6;
public class Program {

  public static void Main(string[] args) {
    Professor newprof1 = new Professor();
    newprof1.prof_name = "Alice";
    newprof1.class_teach = "Java";
    newprof1.SetSalary(9000);
    
    Professor newprof2 = new Professor();
    newprof2.prof_name = "Bob";
    newprof2.class_teach = "Math";
    newprof2.SetSalary(8000);
    
    Student newstu1 = new Student();
    newstu1.stu_name = "Lisa";
    newstu1.class_enroll = "Java";
    newstu1.SetGrade(90);
      
    Student newstu2 = new Student();
    newstu2.stu_name = "Tom";
    newstu2.class_enroll = "Math";
    newstu2.SetGrade(80);

    double salary_diff = newprof1.GetSalary - newprof2.GetSalary;
    double grade_sum = newstu1.GetGrade + newstu2.GetGrade;
    Console.WriteLine("Professor " + newprof1.prof_name +" teaches "+ newprof1.class_teach + ", and the salary is " + newprof1.GetSalary);
    Console.WriteLine("Professor " + newprof2.prof_name +" teaches "+ newprof2.class_teach + ", and the salary is " + newprof2.GetSalary);
    Console.WriteLine("Student " + newstu1.stu_name +" enrolls "+ newstu1.class_enroll + ", and the grade is " + newstu1.GetGrade);
    Console.WriteLine("Student " + newstu2.stu_name +" enrolls "+ newstu2.class_enroll + ", and the grade is " + newstu2.GetGrade);
    Console.WriteLine("The salary difference between "+ newprof1.prof_name + " and " + newprof2.prof_name + " is: "+ salary_diff);
    Console.WriteLine("The total grade of "+ newstu1.stu_name + " and " + newstu2.stu_name + " is: "+ grade_sum);
  }
}
