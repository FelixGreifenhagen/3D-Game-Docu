using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloßBauen : MonoBehaviour
{
    public GameObject Brett;
    public GameObject player;
    public float Distance;

    void Start()
    {
        // floßUI.SetActive(false);
    }

    void Update()
    {
        Distance = Vector3.Distance(Brett.transform.position, player.transform.position);
        if (Distance < 10)
        {
            print("12345");
           // floßUI.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                    // floßUI.SetActive(false);
                    SceneManager.LoadScene("Outtro");
            }
        }
    }
}
