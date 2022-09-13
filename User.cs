public class User {
    public string InputName;
    public string InputSurname;
    public string InputStudentID;
    private Grade gradeInfomation;

    public User(string Name, string Surname, string StudentID, int score) {

        this.InputName = Name;
        this.InputSurname = Surname;
        this.InputStudentID = StudentID;
        this.gradeInfomation = new Grade(score);
    }

    public string PrintGrade() {
        return this.gradeInfomation.ShowGrade();
    }

    public string PrintScore() {
        return this.gradeInfomation.ShowScore();
    }

    public void PrintInoutInformation() {
        return "User Infornmation: "
        + this.Name + this.Surname + " " + 
        this.StudentID + "Score is: " +
        this.gradeInfomation.ShowScore() + "Grade is: ";
        this.gradeInfomation.ShowGrade();
    }
}