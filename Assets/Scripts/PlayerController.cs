using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    CharacterController characterController;
    Animator animator;
    public float speed = 5;
    public float gravity = -5;
    float velocityY = 0; 

    void Start(){
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update () {

        if(Input.GetKey("e")){
            animator.SetTrigger("isWaving");
        }

        velocityY += gravity * Time.deltaTime;

        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        input = input.normalized;

        Vector3 temp = Vector3.zero;
        if (input.z == 1){
            temp += transform.forward;
        }
        else if (input.z == -1){
            temp += transform.forward * -1;
        }

        if (input.x == 1){
            temp += transform.right;
        }
        else if (input.x == -1){
            temp += transform.right * -1;
        }

        Vector3 velocity = temp * speed;
        velocity.y = velocityY;

        characterController.Move(velocity * Time.deltaTime);

        if (characterController.isGrounded)
        {
            velocityY = 0;
        }
    }
}