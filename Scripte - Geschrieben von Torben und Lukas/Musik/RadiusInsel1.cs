using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusInsel1 : MonoBehaviour
{
    public GameObject InselZentrum1;
    public GameObject Player;
    public static AudioClip Insel1;
    static AudioSource audioSrc1;
    public string AudioName1;
    public float MinDis1;
    public float MaxDis1;
    public float Distance1;
    void Start()
    {
        Insel1 = Resources.Load<AudioClip>(AudioName1);
        audioSrc1 = GetComponent<AudioSource>();
    }
    void Update()
    {
        Distance1 = Vector3.Distance(InselZentrum1.transform.position, Player.transform.position);
        if (Distance1 > MinDis1 && Distance1 < MaxDis1)
        {
            playSound();
        }
        if (Distance1 > MaxDis1)
        {
            stopSound();
        }
    }
    public static void playSound()
    {
        audioSrc1.Play(0);
    }
     public static void stopSound()
    {
        audioSrc1.Stop();
    } 
}
