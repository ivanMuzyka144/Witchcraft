using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlSet : MonoBehaviour
{
    private GameController gameController;

    public GameObject PR_Girl;
    private List<Girl> girls;

    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        girls = new List<Girl>();
        for (int i = 0; i < 3; i++)
        {
            Girl thisGirl = (Instantiate(PR_Girl, transform)).GetComponent<Girl>();
            Room roomForGirl = gameController.SetGirl(thisGirl);
            thisGirl.SetRoom(roomForGirl);
            girls.Add(thisGirl);
        }
    }
}
