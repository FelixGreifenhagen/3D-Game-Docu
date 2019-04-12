using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusInsel3 : MonoBehaviour
{
    public GameObject InselZentrum3;
    public GameObject Player;
    public static AudioClip Insel3;
    static AudioSource audioSrc3;
    public string AudioName3;
    public float MinDis3;
    public float MaxDis3;
    public float Distance3;
    void Start()
    {
        Insel3 = Resources.Load<AudioClip>(AudioName3);
        audioSrc3 = GetComponent<AudioSource>();
    }
    void Update()
    {
        Distance3 = Vector3.Distance(InselZentrum3.transform.position, Player.transform.position);
        if (Distance3 > MinDis3 && Distance3 < MaxDis3)
        {
            playSound();
        }
        if (Distance3 > MaxDis3)
        {
            stopSound();
        }
    }
    public static void playSound()
    {
        audioSrc3.Play(0);
    }
    public static void stopSound()
    {
        audioSrc3.Stop();
    }
}
