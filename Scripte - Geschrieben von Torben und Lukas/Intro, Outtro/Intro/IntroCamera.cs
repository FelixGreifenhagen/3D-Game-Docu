using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCamera : MonoBehaviour
{
    public Transform[] CameraTarget;
    public float speed;

    private int current;

    void Update()
    { 
        if (transform.position != CameraTarget[current].position)
            {
            Vector3 pos = Vector3.MoveTowards(transform.position, CameraTarget[current].position, speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
            }
        else current = (current + 1) % CameraTarget.Length;
    }
}
