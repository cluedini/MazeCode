using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public GameObject player;
    public GameObject crystal;
    public GameObject exit;
    public Tilemap walls;
    public float timeRemaining = 180;
    public bool timerIsRunning = false;
    public Text timeText;
    public bool canMove=false;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Lose();
            }
        }
        //movement and check if wall exists
        if (canMove == true)
        {


            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector3Int wallTile = walls.WorldToCell(player.transform.position + new Vector3(0, 1));

                if (walls.GetTile(wallTile) == null)
                {
                    player.transform.Translate(new Vector3(0, 1));
                }

            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                Vector3Int wallTile = walls.WorldToCell(player.transform.position + new Vector3(0, -1));
                if (walls.GetTile(wallTile) == null)
                    player.transform.Translate(new Vector3(0, -1));
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Vector3Int wallTile = walls.WorldToCell(player.transform.position + new Vector3(1, 0));
                if (walls.GetTile(wallTile) == null)
                    player.transform.Translate(new Vector3(1, 0));
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                Vector3Int wallTile = walls.WorldToCell(player.transform.position + new Vector3(-1, 0));
                if (walls.GetTile(wallTile) == null)
                    player.transform.Translate(new Vector3(-1, 0));
            }
        }
       
    }

    void Lose()
    {
        lose.SetActive(true);
        canMove = false;
        
    }
    

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
