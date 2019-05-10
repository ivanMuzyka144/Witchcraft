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
        
    }
}
