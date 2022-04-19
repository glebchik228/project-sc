using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcam : MonoBehaviour
{
    [SerializeField] int a;
    public Outline ol;
    public bool isnotDragon = true;
    void Start()
    {
        Outline ol = gameObject.GetComponent<Outline>();
    }

    void OnMouseDown()
    {
        if (isnotDragon)
            camcamcam.x = a;
        else
        {
            if (!misslook.blockmove)
                cutscen6._startcutscensix.Invoke();
            if (flower.flowered)
                dragonsc._dragonHum.Invoke();
        }
    }
    void OnMouseEnter()
    {
        ol.enabled = true;
    }
    void OnMouseExit()
    {
        ol.enabled = false;
    }
}
