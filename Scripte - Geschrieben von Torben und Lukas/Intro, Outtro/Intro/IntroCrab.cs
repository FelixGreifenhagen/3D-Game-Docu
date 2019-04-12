using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCrab : MonoBehaviour
{
    public Transform[] CrabTarget;
    public float speed;

    private int current;

    void Update()
    {
        if (transform.position != CrabTarget[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, CrabTarget[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % CrabTarget.Length;
    }
}