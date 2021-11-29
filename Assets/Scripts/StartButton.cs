using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject gameScreen, gameManager;
    private void OnMouseOver()
    {
        transform.localScale = new Vector3(2.8f, 2.8f, 2.8f);
        if(Input.GetMouseButtonDown(0))
        {
            gameScreen.SetActive(true);
            gameManager.GetComponent<Controller>().timerIsRunning=true;
            gameManager.GetComponent<Controller>().canMove=true;
            gameObject.transform.parent.gameObject.SetActive(false);


        }
    }
    private void OnMouseExit()
    {
        transform.localScale = new Vector3(2.7f, 2.7f, 2.7f);
    }
}
