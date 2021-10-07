using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rgbody;
    private float inputX, inputY;
    public Animator anim;
    public float speed = 0;
    private void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        Movement();
        AnimPlay();
        Flip();
    }
    private void Movement()
    {
        if (inputX!=0||inputY!=0)
        {
            transform.Translate(new Vector3(inputX,inputY,0).normalized*speed*Time.deltaTime);
        }
    }
    private void AnimPlay()
    {
        if (inputX != 0 || inputY != 0)
        {
            anim.Play("player0_run");
        }
        else
        {
            anim.Play("player0_idle");
        }
    }
    private void Flip()
    {
        if (inputX!=0)
        {
            transform.localScale = new Vector3(inputX, 1, 1);
        }
    }
}
