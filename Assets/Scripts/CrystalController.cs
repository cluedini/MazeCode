using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalController : MonoBehaviour
{
    public GameObject crystal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("hacker voice im in");
        //if (collision.gameObject.tag == "player")
        //{
          //  crystal.GetComponent<SpriteRenderer>().enabled = false;
            //crystal.gameObject.SetActive(false);
        //}
    }
}
