namespace partialClass_8;

public partial class StudentPartial
{
    private string firstName;
   private string lastName;

   public string FirstName
    { 
       set { firstName = value; }
        
        get { return firstName; }
     }

    public string LastName 
    { 
     set {lastName = value;} 

     get {return lastName;} 
      }
}
