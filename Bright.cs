using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bright : MonoBehaviour
{
    static public bool bright = false;
    static public bool mslk = false;
    public Animation myAn;
    public GameObject player;
    public GameObject witch;
    private int i = 0;
    private bool pls = false;

    void Start()
    {
        myAn = GetComponent<Animation>();
        myAn.Play("effect anim");
    }

    void Update()
    {
        if (bright)
        {
            myAn.Play("effect anim"); 
        }

        if (pls)
        {
            myAn.Play("pulse");
        }
        i++;
        if (i % 100 == 0)
        {
            float distanseToWitch = Vector3.Distance(player.transform.position, witch.transform.position);
            pls = distanseToWitch < 30f;
            if (distanseToWitch < 5f)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            i = 0;
        }
    }

    public void OnceBright()
    {
        bright = false;
    }
    public void MissLookYes()
    {
        mslk = true;
    }
    public void MissLookNo()
    {
        mslk = false;
    }
}
