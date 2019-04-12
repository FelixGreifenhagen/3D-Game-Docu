using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public Animator HouseAnimatiomn;
    public GameObject door;
    public float Distance;
    public GameObject Player;
    void Start()
    {
        HouseAnimatiomn = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(door.transform.position, Player.transform.position);
        if (GameObject.Find("Schlüssel") == null && Distance <= 8) { 
            if(Input.GetKey(KeyCode.E))
            {
                HouseAnimatiomn.SetBool("openDoor", true);
            }            
        }
    }
}
