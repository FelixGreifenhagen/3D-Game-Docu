using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMission : MonoBehaviour
{
    public GameObject collideBox;
    public GameObject doItCanvas;
    public GameObject player;
    public float Distance;
    void Start()
    {
        doItCanvas.SetActive(false);
    }
    void Update()
    {
        Distance = Vector3.Distance(collideBox.transform.position, player.transform.position);
        if (GameObject.Find("Holz") == null && GameObject.Find("Liane") == null && GameObject.Find("Stein") == null && GameObject.Find("Blatt") == null)
        {
            if(Distance < 10)
            {
                doItCanvas.SetActive(true);
            }
            if(Distance > 10)
            {
                doItCanvas.SetActive(false);
            }
        }
    }
}
