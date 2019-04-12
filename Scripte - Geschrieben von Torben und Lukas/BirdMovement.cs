using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Transform[] BirdTarget;
    public float speed;

    private int current;

    void Update()
    {
        if (transform.position != BirdTarget[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, BirdTarget[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % BirdTarget.Length;
    }
}