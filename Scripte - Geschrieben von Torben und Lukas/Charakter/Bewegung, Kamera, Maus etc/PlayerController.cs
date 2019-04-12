using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))] 

public class PlayerController : MonoBehaviour {
    //public int forceConst = 50;
    public float moveSpeed;
    private float mouseX = 0.0f;
    private float mouseY = 0.0f;
    public float speedX = 2.0f;
    public float speedY = 2.0f;
    public Rigidbody RigidBody;
    
    void Start() {
        moveSpeed = 1.5f;        
    }
    void Update() {
        bool isPaused = EscapeMenu.GamePaused;
        bool gameOver = healthScript.gameIsOver;
        if (isPaused == false && gameOver == false) 
        {
            mouseX += speedX * Input.GetAxis("Mouse X");
            mouseY -= speedY * 0f;
        }
        transform.eulerAngles = new Vector3(0.0f, mouseX, 0.0f);
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = 4f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveSpeed = 1f;
            }
            transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
            moveSpeed = 1.5f;            
        
    }
}
