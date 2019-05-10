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
        room.AddPerson(player.gameObject);
        return room;
    }

    public void MakePlayerTurn(Room startRoom, Room finishRoom)
    {
        startRoom.RemovePerson(player.gameObject);
        gameRenderer.RenderPlayerMove(startRoom, finishRoom);
        player.SetCurrentRoom(finishRoom);
        finishRoom.AddPerson(player.gameObject);
    }

    public Room SetGirl(Girl girl)
    {
        Room selectedRoom = null;
        
        for(int i = 0; i< 5; i++)
        {
            int numberOfRoom = UnityEngine.Random.Range(0, 6);
            selectedRoom = house.GetSelectedRoom(numberOfRoom);
            if(selectedRoom.GetCountOfPersons() < 5)
            {
                break;
            }
        }
        gameRenderer.SetGirl(girl, selectedRoom);
        selectedRoom.AddPerson(girl.gameObject);
        return selectedRoom;
    }

    public void PlayerHasEndedTurn()
    {
    }

}
