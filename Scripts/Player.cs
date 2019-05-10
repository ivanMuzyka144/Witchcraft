using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private GameController gameController;

    private Room currentRoom;

    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        currentRoom = gameController.SetPlayer(0);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (HasRelatedRoom("w"))
            {
                Room startRoom = currentRoom;
                Room finishRoom = currentRoom.GetRoom("w");
                gameController.MakePlayerTurn(startRoom, finishRoom);
                gameController.PlayerHasEndedTurn();
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (HasRelatedRoom("s"))
            {
                Room startRoom = currentRoom;
                Room finishRoom = currentRoom.GetRoom("s");
                gameController.MakePlayerTurn(startRoom, finishRoom);
                gameController.PlayerHasEndedTurn();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (HasRelatedRoom("a"))
            {
                Room startRoom = currentRoom;
                Room finishRoom = currentRoom.GetRoom("a");
                gameController.MakePlayerTurn(startRoom, finishRoom);
                gameController.PlayerHasEndedTurn();
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (HasRelatedRoom("d"))
            {
                Room startRoom = currentRoom;
                Room finishRoom = currentRoom.GetRoom("d");
                gameController.MakePlayerTurn(startRoom, finishRoom);
                gameController.PlayerHasEndedTurn();
            }
        }

    }

    bool HasRelatedRoom(string command)
    {
        return currentRoom.HasRoom(command);
    }

    public void SetCurrentRoom(Room room)
    {
        currentRoom = room;
    }
}
