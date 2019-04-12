using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoorText : MonoBehaviour
{
    public GameObject GameTextUI;
    public GameObject door;
    public float Distance;
    public GameObject Player;
    public bool doorOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(door.transform.position, Player.transform.position);
        if (GameObject.Find("Schlüssel") == null && Distance <= 8) {
            if(doorOpen == false)
            {
                GameTextUI.SetActive(true);
            }            
            if(Input.GetKey(KeyCode.E))
            {
                doorOpen = true;
            }
        }
        if(Distance > 8 || doorOpen == true)
        {
            GameTextUI.SetActive(false);
        }
    }
}
