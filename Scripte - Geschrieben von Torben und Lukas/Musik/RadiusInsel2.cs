using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusInsel2 : MonoBehaviour
{
    public GameObject InselZentrum2;
    public GameObject Player;
    public static AudioClip Insel2;
    static AudioSource audioSrc2;
    public string AudioName2;
    public float MinDis2;
    public float MaxDis2;
    public float Distance2;
    void Start()
    {
        Insel2 = Resources.Load<AudioClip>(AudioName2);
        audioSrc2 = GetComponent<AudioSource>();
    }
    void Update()
    {
        Distance2 = Vector3.Distance(InselZentrum2.transform.position, Player.transform.position);
        if (Distance2 > MinDis2 && Distance2 < MaxDis2)
        {
            playSound();
        }
        if (Distance2 > MaxDis2)
        {
            stopSound();
        }
    }
    public static void playSound()
    {
        audioSrc2.Play(0);
    }
    public static void stopSound()
    {
        audioSrc2.Stop();
    }
}
