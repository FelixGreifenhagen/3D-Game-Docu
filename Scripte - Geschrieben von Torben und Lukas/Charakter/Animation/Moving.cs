using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public Animator move;
    void Start() {
        move = GetComponent<Animator>();
    }
    void Update() {

        if (Input.GetKey(KeyCode.W)) {
            move.SetBool("Moving", true);
        }
        if(!Input.GetKey(KeyCode.W)) {
            move.SetBool("Moving", false);
        }
    }
}
