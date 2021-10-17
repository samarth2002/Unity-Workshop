using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public Text score;
    // Start is called before the first frame update
    void Start()
    {
      //  score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //score.text = transform.position.z.ToString("0");
        //Debug.Log(score);
        Debug.Log(transform.position.z);
    }
}
