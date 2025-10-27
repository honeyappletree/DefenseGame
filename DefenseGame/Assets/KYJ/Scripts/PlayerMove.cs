using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    private float moveSpeed = 80;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal();
        float y = joystick.Vertical();

        if(x != 0 || y != 0)
        {
            transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;

   
        //    if(x < -322)
        //    {
        //        transform.position = new Vector3(-322, transform.position.y, transform.position.z);
        //    }

        //    else if(x > 414)
        //    {
        //        transform.position = new Vector3(414, transform.position.y, transform.position.z);
        //    }

        //    else if(y < -823)
        //    {
        //        transform.position = new Vector3(transform.position.x, -823, transform.position.z);
        //    }

        //    else if(y > 823)
        //    {
        //        transform.position = new Vector3(transform.position.x, 823, transform.position.z);
        //    }
        }
    }
}
