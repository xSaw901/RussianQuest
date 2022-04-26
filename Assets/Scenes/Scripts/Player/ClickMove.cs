using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public float speed;
    private Animator animator;
    public Vector3 TargetPosition;
    public bool isMoving = false;
    private bool Lookright = true;
    public bool stop=false;
    public bool Xvat = false;
    private int k = 0;
    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        //Поле куда можно кликать
        if (stop == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                
                TriggerPosition();
                k = 0;
            }

            if (isMoving)
            {
                ItsMove();
                animator.SetBool("Walking", true);

            }
            else
            {
                animator.SetBool("Walking", false);
            }
        }
        if (stop == true && k==0)
        { 
         TargetPosition = transform.position;
         animator.SetBool("Walking", false);
         if(Xvat && k==0)
         {
                animator.SetTrigger("Xvat");
         }
            k++;
        }

    }

    void TriggerPosition()
    {
        TargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        TargetPosition.z = transform.position.z;
        isMoving = true;
        if (transform.position.x > TargetPosition.x && Lookright) Flip();
        if (transform.position.x < TargetPosition.x && !Lookright) Flip();
    }

    void ItsMove()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);

        if(transform.position == TargetPosition)
        {
            isMoving = false;
        }
        


    }
    void Flip()
    {
        Lookright = !Lookright;
        transform.Rotate(0f, 180f, 0f);
               
    }   
}
