using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missioncont : MonoBehaviour
{
    public Text _MissionText;
    public static int _MissionNumber = 0;

    
    void Update()
    {
        switch (_MissionNumber)
        {
            case 1:
                _MissionText.GetComponent<Text>().text = "Соберите 10 морковок с морковного поля и принесите розовому кролику";
                break;
            case 2:
                _MissionText.GetComponent<Text>().text = "Найдите гоблина в лесу";
                break;
            case 3:
                _MissionText.GetComponent<Text>().text = "Отведите гоблина к могучему дереву";
                uiTarget.target = 3;
                break;
            case 4:
                _MissionText.GetComponent<Text>().text = "Найдите в горах цветок-ветерок и принесите дракону";
                break;
        }
            
    }
}
