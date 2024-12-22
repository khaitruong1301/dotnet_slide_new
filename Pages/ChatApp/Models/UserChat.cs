using System;

class UserChat {
    private static string UserId {get; set;} 
    private string Id {get; set;}
    private string UserName {get; set;}
    public string Content {get;set;}

    public UserChat() {
        UserId = new Guid().ToString();
        Id = UserId;
    }
}



