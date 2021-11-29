using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject crystal;
    public GameObject gameManager;
    private bool crystalCollected;
    public GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        crystalCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="crystal")
        {
            crystal.GetComponent<SpriteRenderer>().enabled = false;
            crystalCollected = true;
        }
        if(collision.gameObject.tag=="exit")
        {
            if(crystalCollected==true)
            {
                //exit
                win.SetActive(true);
                gameManager.GetComponent<Controller>().canMove = false;
                gameManager.GetComponent<Controller>().timerIsRunning=false;
                gameManager.GetComponent<Controller>().timeRemaining = 0;
                gameManager.SetActive(false);
                Debug.Log("exit");
            }
            else
            {
                //do not exit
                Debug.Log("stay");
            }
        }
    }
}
