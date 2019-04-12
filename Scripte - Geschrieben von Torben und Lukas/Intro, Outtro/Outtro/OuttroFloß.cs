using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuttroFloß : MonoBehaviour
{
    public Transform[] FloßTarget;
    public float speed;

    private int current;

    void Update()
    {
        if (transform.position != FloßTarget[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, FloßTarget[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % FloßTarget.Length;
    }
}