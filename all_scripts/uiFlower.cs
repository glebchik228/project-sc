using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiFlower : MonoBehaviour
{
    public GameObject flowerr;
    void Update()
    {
        flowerr.SetActive(flower.flowered);
        if (flower.flowered)
            uiTarget.target = 5;
    }
}
