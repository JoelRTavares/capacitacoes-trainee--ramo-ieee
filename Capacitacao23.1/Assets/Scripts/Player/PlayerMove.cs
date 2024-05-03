using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    [SerializeField] private float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xMove = Input.GetAxis("Horizontal");//direita = 1f/ esquerda = -1f
        float yMove = Input.GetAxis("Vertical");//cima = 1/ baixo= -1

        rig.velocity = new Vector2(xMove, yMove)* speed * Time.fixedDeltaTime;

        if(xMove == 0 && yMove == 0)
        {
            anim.Play("PlayerIdle");
        }
        else
        {
            anim.Play("PlayerWalk");

            if (xMove > 0)
                transform.eulerAngles = new Vector3(0, 0, 0);
            else if (xMove < 0)
                transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}


