using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    private Room leftRoom;
    private Room topRoom;
    private Room rightRoom;
    private Room bottomRoom;


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
}
