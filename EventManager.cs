using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{
    public delegate void MoveAction();
    public static event MoveAction OnMoved;
    [SerializeField] PlayerData playerData;


    void Update()
    {
        if (playerData.playerMoved)
        {
            OnMoved();
            playerData.playerMoved = false;
        }
    }
}