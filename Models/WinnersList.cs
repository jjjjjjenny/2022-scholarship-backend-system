namespace _2022_scholarship_backend_system.Models;

public class WinnersList
{
    public string id{get;set;}

    public string title{get;set;}
    
    public int spot{get; set;}

    public int amount{get; set;}

    public bool onCampus{get; set;}

    public override string ToString()
    {
        return this.title+"\n"+"分配名額："+this.spot+"\n"+"獎學金金額："+this.amount;
    }
}