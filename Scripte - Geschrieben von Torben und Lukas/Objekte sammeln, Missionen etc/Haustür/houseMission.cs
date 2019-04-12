using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseMission : MonoBehaviour
{
    public GameObject missionText;
    public string gameObjectName;
    public string keyObjectName;
    void Start()
    {
        missionText.SetActive(false);
    }
    void Update()
    {
        if(GameObject.Find(keyObjectName) == null)
        {
            missionText.SetActive(true);
        }
        if (GameObject.Find(gameObjectName) == null)
        {
            missionText.SetActive(false);
        }
    }
}
