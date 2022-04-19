using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class treeAnsSc : MonoBehaviour
{
    static public UnityAction _starttreeans;
    public GameObject answer;
    public InputField txtOfAns;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    public GameObject obstacle;
    public string last = "";
    void Start()
    {
        _starttreeans = TreeAns;
    }
    public void TreeAns()
    {
        answer.SetActive(true);
        Time.timeScale = 0;
    }
    void Update()
    {
        if (txtOfAns.text != last)
        {
            last = txtOfAns.text;
            ButSound.snd = true;
        }
    }

    public void CheckAns()
    {
        ButSound.snd = true;
        if ((txtOfAns.text == "Часы") || (txtOfAns.text == "часы"))
        {
            Time.timeScale = 1;
            cutPlayer.SetActive(false);
            answer.SetActive(false);
            cutscen5._startcutscenfive.Invoke();
            obstacle.SetActive(false);
        }
        else
            txtOfAns.text = "";


    }
}
