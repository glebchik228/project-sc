using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecont : MonoBehaviour
{
    public Text _ScoreText;
    public static int score;

    void Update()
    {
        if (missioncont._MissionNumber == 1)
            _ScoreText.GetComponent<Text>().text = score.ToString() + "/10";
        else
            _ScoreText.GetComponent<Text>().text = " ";
    }
}
