using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "obstacle")
        {
            gameManager.EndGame();
        }
    }


}
