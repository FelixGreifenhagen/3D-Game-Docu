using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectMissionObject : MonoBehaviour
{
    public GameObject player;

    public GameObject missionCompleteUI;

    public GameObject lianen;
    public GameObject holz;
    public GameObject steine;
    public GameObject blaetter;
    public Text text;

    public GameObject lianenCollider;
    public GameObject holzCollider;
    public GameObject blaetterCollider;
    public GameObject steineCollider;

    public GameObject blaetterUI;
    public GameObject lianenUI;
    public GameObject steineUI;
    public GameObject holzUI;

    public GameObject blaetterPickUpUI;
    public GameObject holzPickUpUI;
    public GameObject steinePickUpUI;
    public GameObject lianenPickUpUI;

    public float distanceBlaetter;
    public float distanceLianen;
    public float distanceSteine;
    public float distanceHolz;

    public bool find;
    void Start()
    {
         blaetterUI.SetActive(false);
        lianenUI.SetActive(false);
        steineUI.SetActive(false);
        holzUI.SetActive(false);

        blaetterPickUpUI.SetActive(false);
        holzPickUpUI.SetActive(false);
        steinePickUpUI.SetActive(false);
        lianenPickUpUI.SetActive(false);

        missionCompleteUI.SetActive(false);

    }
    void Update()
    {
       // blaetterUI.SetActive(true);
        //print(find);
        if(GameObject.Find("Bauplan") == null)
        {
            find = true;
            if(GameObject.Find("Blatt") != null)
            {
                blaetterUI.SetActive(true);
            }
            if(GameObject.Find("Stein") != null)
            {
                steineUI.SetActive(true);
            }
            if(GameObject.Find("Liane") != null)
            {
                lianenUI.SetActive(true);
            }
            if(GameObject.Find("Holz") != null)
            {
                holzUI.SetActive(true);
            }  
        }  
        distanceBlaetter = Vector3.Distance(blaetterCollider.transform.position, player.transform.position);
        distanceLianen = Vector3.Distance(lianenCollider.transform.position, player.transform.position);
        distanceSteine = Vector3.Distance(steineCollider.transform.position, player.transform.position);
        distanceHolz = Vector3.Distance(holzCollider.transform.position, player.transform.position);
        
        if (distanceLianen <= 11)
        {
            if (GameObject.Find("Liane"))
            {
                lianenPickUpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    lianenUI.SetActive(false);
                    Destroy(lianen);
                    lianenPickUpUI.SetActive(false);
                }
            }
        }        
        if (distanceBlaetter <= 6)
        {
            if (GameObject.Find("Blatt"))
            {
                blaetterPickUpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {                    
                    blaetterUI.SetActive(false);
                    Destroy(blaetter);
                    blaetterPickUpUI.SetActive(false);
                }
            }
        }        
        if (distanceSteine <= 6)
        {
            if (GameObject.Find("Stein"))
            {
                steinePickUpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    steinePickUpUI.SetActive(false);
                    steineUI.SetActive(false);
                    Destroy(steine);
                }
            }
        }       
        if (distanceHolz <= 6)
        {
            if (GameObject.Find("Holz"))
            {
                holzPickUpUI.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    holzUI.SetActive(false);
                    Destroy(holz);
                    holzPickUpUI.SetActive(false);
                }
            }
        }
        if(GameObject.Find("Holz") == null && GameObject.Find("Liane") == null && GameObject.Find("Stein") == null && GameObject.Find("Blatt") == null)
        {
            missionCompleteUI.SetActive(true);
        }
    }
}
