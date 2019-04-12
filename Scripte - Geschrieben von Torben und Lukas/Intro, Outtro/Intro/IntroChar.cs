using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroChar : MonoBehaviour
{
    public Transform[] CharTarget;
    public float speed;

    private int current;

    void Update()
    {
        if (transform.position != CharTarget[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, CharTarget[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % CharTarget.Length;
    }
}
