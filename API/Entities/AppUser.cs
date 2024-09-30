namespace API.Entities;

public class AppUser
{
    // internal, private or public
    //[Key] si queremos cambiar por Id
    public int Id { get; set; } // default value 0
    //public string UserName { get; set; } = "";
    public required string UserName { get; set;}
}
