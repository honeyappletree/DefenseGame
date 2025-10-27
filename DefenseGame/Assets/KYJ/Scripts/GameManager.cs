using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text timer;
    float limitTime = 300;
    int min;
    float sec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limitTime -= Time.deltaTime;

        if(limitTime >= 60f)
        {
            min = (int)limitTime / 60;
            sec = limitTime % 60;
            timer.text = min + ":" + (int)sec;
        }

        if(limitTime < 60f)
        {
            timer.text = min + ":" + (int)sec;
        }

        if(limitTime <= 0)
        {
            timer.text = "00 : 00";
        }
    }
}
