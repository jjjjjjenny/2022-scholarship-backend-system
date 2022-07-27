namespace _2022_scholarship_backend_system.Models;

public class WinnerListResult
{   
    // 學生
    public Dictionary<string, List<WinnersStudentInfo>> WinnersStudentInfo {get; set;}
    // 獎學金
    public List<WinnersList> WinnersList {get; set;}
}
