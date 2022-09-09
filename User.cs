public class User {
    private string InputName;
    private string InputSurname;
    private string InputStudentID;

    public User(string Name, string Surname, string StudentID) {

        InputName = Name;
        InputSurname = Surname;
        InputStudentID = StudentID;
    }

    public void PrintInoutInformation() {
        Console.WriteLine();
        Console.Write("Name: {0}",InputName);
        Console.Write(InputSurname);
        Console.Write(InputStudentID);
        Console.WriteLine();
    }
}