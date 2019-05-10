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

        house.BuildHouse();
    }
    
}
