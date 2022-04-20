using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking2d : MonoBehaviour
{
    public int speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 0)
                GoRight();
            else
                transform.position = new Vector3(-130f, transform.position.y,transform.position.z);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > -130)
            GoLeft();
        if (Input.GetKey(KeyCode.W) && transform.position.y < 30)
            GoUp();
        if (Input.GetKey(KeyCode.S) && transform.position.y > -30)
            GoDown();
    }

    void GoRight()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
    void GoLeft()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);;
    }
    void GoUp()
    {
        transform.position += new Vector3(0,speed * Time.deltaTime,  0);
    }
    void GoDown()
    {
        transform.position -= new Vector3(0,speed * Time.deltaTime,  0);
    }
}
