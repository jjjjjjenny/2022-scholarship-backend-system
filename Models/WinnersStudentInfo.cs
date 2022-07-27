namespace _2022_scholarship_backend_system.Models;

public class WinnersStudentInfo
{
    public string? name{get; set;}
    public string? major {get; set;}

    public string id{get;set;}

    public override string ToString(){
        return this.name+"("+this.id+" "+this.major+")";
    }

}