using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyMission : MonoBehaviour
{
    public GameObject missionText;
    public string gameObjectName;
    void Start()
    {
        missionText.SetActive(true);
    }
    void Update()
    {
        if(GameObject.Find(gameObjectName) == null)
        {
            missionText.SetActive(false);
        }        
    }
}
