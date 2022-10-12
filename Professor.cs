class Professor{
    public string prof_name;
    public string class_teach;
    private double salary;
    public void SetSalary(double salary_amount){
      salary = salary_amount;}
    public double GetSalary{
      get {return salary;}
      set {salary = value;}
    }
  }