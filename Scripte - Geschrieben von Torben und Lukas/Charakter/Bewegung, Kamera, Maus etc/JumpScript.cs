using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class JumpScript : MonoBehaviour
{
    public float Timer;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public static bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        isGrounded = true;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionEnter()
    {
        isGrounded = true;
    }
    
}
