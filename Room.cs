using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    private Room leftRoom;
    private Room topRoom;
    private Room rightRoom;
    private Room bottomRoom;

    private List<GameObject> personsInRoom = new List<GameObject>();


    public void SetRoomPosition(int x, int y)
    {
        transform.position = new Vector3(x, y, 0);
    }

    public void SetRelatedRooms(Room leftRoom, Room topRoom, Room rightRoom, Room bottomRoom)
    {
        this.leftRoom = leftRoom;
        this.topRoom = topRoom;
        this.rightRoom = rightRoom;
        this.bottomRoom = bottomRoom;
    }


    public bool HasRoom(string command)
    {
        switch (command)
        {
            case "w": return this.topRoom != null;
            case "a": return this.leftRoom != null;
            case "s": return this.bottomRoom != null;
            case "d": return this.rightRoom != null;
            default: return false;
        }
    }

    public Room GetRoom(string command)
    {
        switch (command)
        {
            case "w": return this.topRoom;
            case "a": return this.leftRoom;
            case "s": return this.bottomRoom;
            case "d": return this.rightRoom;
            default: return null;
        }
    }

    public void AddPerson(GameObject person)
    {
        personsInRoom.Add(person);
    }

    public void RemovePerson(GameObject person)
    {
        personsInRoom.Remove(person);
    }

    public int GetCountOfPersons()
    {
        return personsInRoom.Count;
    }
}
