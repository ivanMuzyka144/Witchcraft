using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameRenderer gameRenderer;
    private Player player;
    private House house;

    void Start()
    {
        gameRenderer = GameObject.Find("GameRenderer").GetComponent<GameRenderer>();
        player = GameObject.Find("Player").GetComponent<Player>();
        house = GameObject.Find("House").GetComponent<House>();
        
    }

    public Room SetPlayer(int numberOfRoom)
    {
        Room room = house.GetSelectedRoom(0);
        gameRenderer.SetPlayer(room);
        return room;
    }

    public void MakePlayerTurn(Room startRoom, Room finishRoom)
    {
        gameRenderer.RenderPlayerMove(startRoom, finishRoom);
        player.SetCurrentRoom(finishRoom);
    }

    public void PlayerHasEndedTurn()
    {
    }

}
