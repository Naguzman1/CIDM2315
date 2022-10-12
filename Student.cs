class Student{
    public string stu_name;
    public string class_enroll;
    private double grade;
    public void SetGrade(double grade_points){
      grade = grade_points;
    }
    public double GetGrade{
      get {return grade;}
      set {grade = value;}
    }
  }