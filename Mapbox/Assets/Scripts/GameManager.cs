﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Player currentPlayer;

    public Player CurrentPlayer
    {
        get 
        {
            if (currentPlayer == null)
            {
                currentPlayer = gameObject.AddComponent<Player>();
            }
            return currentPlayer; 
        }
    }

}
