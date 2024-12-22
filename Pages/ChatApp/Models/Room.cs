using System.Collections.Generic;

class Room {
    private static int RoomId {get; set;} = 1;

    private int Id {get;set;}
    private string Name {get;set;}
    private int NumberOfPeople {get;set;} = 0;

    private List<UserChat> lstUsers = new List<UserChat>();
    public Room(){
        Id = RoomId;
        RoomId++;
    }

}