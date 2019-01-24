using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
 
    public Animator animator;
    public Joystick joystick;
    public float runSpeed = 0.02f;

    float MoveH = 0f;
    float MoveV = 0f;
 
    void Update()
    {

        if (joystick.Horizontal >= .2f)
        {
                MoveH = runSpeed;
        }
        else if (joystick.Horizontal  <= -.2f)
        {
                MoveH = -runSpeed;
        }
        else MoveH=0f;

        if (joystick.Vertical >= .2f)
        {
                MoveV = runSpeed;
        }
        else if (joystick.Vertical  <= -.2f)
        {
                MoveV = -runSpeed;
        }
        else MoveV=0f;



        Vector3 movement = new Vector3(MoveH,MoveV,0.0f);
        

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        transform.position = transform.position + movement * Time.deltaTime;
    }
}
