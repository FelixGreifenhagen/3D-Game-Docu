using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAxe : MonoBehaviour
{
    public GameObject KeyBox;
    public GameObject Player;
    public float Distance;
    public GameObject AxeTextUI;
    public static AudioClip Pickup;
    static AudioSource soundeffect;
    public string soundeffectName;
    void Start()
    {
        AxeTextUI.SetActive(false);
        Pickup = Resources.Load<AudioClip>(soundeffectName);
        soundeffect = GetComponent<AudioSource>();
    }
    void Update()
    {
        Distance = Vector3.Distance(KeyBox.transform.position,Player.transform.position);
        //print(Distance);

        if(Distance <= 3)
        {
            if (GameObject.Find("Schlüssel") != null)
                {
                AxeTextUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    Destroy(gameObject);
                    AxeTextUI.SetActive(false);
                    soundeffect.Play();
                }                   
            }
        }
        else
        {
            AxeTextUI.SetActive(false);
        }
    }
}
