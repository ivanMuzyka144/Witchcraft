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

}
