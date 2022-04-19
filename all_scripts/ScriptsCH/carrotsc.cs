using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotsc : MonoBehaviour
{
    public Outline eee;
    public GameObject carrot;
    void Start()
    {
        Outline eee = gameObject.GetComponent<Outline>();
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        carrot.transform.position = transform.position + new Vector3(0f, 2f, 0f);
        Instantiate(carrot);
    }
    void OnMouseEnter()
    {
        eee.enabled = true;
    }
    void OnMouseExit()
    {
        eee.enabled = false;
    }
}
