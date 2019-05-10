using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRenderer : MonoBehaviour
{
    private GameController gameController;
    private Player player;
    private House house;

    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        player = GameObject.Find("Player").GetComponent<Player>();
        house = GameObject.Find("House").GetComponent<House>();
    }

    public void SetPlayer(Room room)
    {
        Vector3 centerOfRoom = room.transform.position;
        centerOfRoom.z = -2;
        player.transform.position = centerOfRoom;
        
    }

    public void RenderPlayerMove(Room startRoom, Room finishRoom)
    {
        Vector3 centerOfFinishRoom = finishRoom.transform.position;
        centerOfFinishRoom.z = -2;
        player.transform.position = centerOfFinishRoom;
    }

    public void SetGirl(Girl girl, Room room)
    {
        Vector3 centerOfRoom = room.transform.position;
        centerOfRoom.z = -1;
        switch (room.GetCountOfPersons())
        {
            case 1:
                centerOfRoom.x -= 0.6f;
                break;
            case 2:
                centerOfRoom.x += 0.6f;
                break;
            case 3:
                centerOfRoom.y -= 0.6f;
                break;
            case 4:
                centerOfRoom.y += 0.6f;
                break;
        }
        girl.transform.position = centerOfRoom;
    }
}
