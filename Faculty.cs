using System;

class Faculty : Person{
  public string Id { get; set; }
  public string Title { get; set; }
  public DateTime DateOfEmployment{ get; set; }
  public string Employer { get; set; }
  public decimal YearlySalary { get; set; }
  public bool Tenuerd { get; set; }

 public Faculty()
 {
   Title = "Instructor";
   
 }

public Faculty(string FName, string LName)
{
  Title = "Instructor";
  FirstName = FName;
  LastName = LName;
  
}

  public string GrantTenure()
{
   if ((DateTime.Today.Year - DateOfEmployment.Year) >=5  )
   {Tenuerd = true;
    return "true";}
   else
   {Tenuerd = false;
    return "false";}

}

public void Promote()
{
  if (Title == "Instructor" && 
  (DateTime.Today.Year - DateOfEmployment.Year) > 2)
  {
    Title = "Assistant Professor";
    Console.WriteLine("Faculty has been promoted to Assistant Professor rank.");
  }
  if (Title == "Assistant Professor" && 
  (DateTime.Today.Year - DateOfEmployment.Year) > 5)
  {
    Title = "Associate Professor";
    Console.WriteLine("Faculty has been promoted to Associate Professor rank.");
  }
  if (Title == "Associate Professor" && 
  (DateTime.Today.Year - DateOfEmployment.Year) > 10)
  {
    Title = "Professor";
    Console.WriteLine("Faculty has been promoted to Professor rank.");
  }

  if (Title == "Professor")
  {
    Console.WriteLine("No more promotion is possible.");
  }
}

public override void Intro()
{
  base.Intro();
  Console.WriteLine("I work as " + Title + " at " + Employer + " since " + DateOfEmployment.Year + ".");
}


}