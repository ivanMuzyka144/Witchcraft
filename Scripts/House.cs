using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public GameObject PR_Room;
    public List<Room> rooms;

    public void BuildHouse()
    {
        rooms = new List<Room>();

        for (int i = 0; i < 7; i++)
        {
            GameObject thisRoom = Instantiate(PR_Room, transform);
            thisRoom.transform.position = new Vector3(0, 0, 0);
            rooms.Add(thisRoom.GetComponent<Room>());
        }

        rooms[0].SetRelatedRooms(null, rooms[1], rooms[2], rooms[4]);
        rooms[1].SetRelatedRooms(null, null, null, rooms[0]);
        rooms[2].SetRelatedRooms(rooms[0], null, null, rooms[5]);
        rooms[3].SetRelatedRooms(null, null, rooms[4], null);
        rooms[4].SetRelatedRooms(rooms[3], rooms[0], rooms[5], null);
        rooms[5].SetRelatedRooms(rooms[4], rooms[2], rooms[6], null);
        rooms[6].SetRelatedRooms(rooms[5], null, null, null);

        //correct this part

        rooms[1].SetRoomPosition(0, 2);
        rooms[2].SetRoomPosition(2, 0);
        rooms[3].SetRoomPosition(-2, -2);
        rooms[4].SetRoomPosition(0, -2);
        rooms[5].SetRoomPosition(2, -2);
        rooms[6].SetRoomPosition(4, -2);
    }
}
