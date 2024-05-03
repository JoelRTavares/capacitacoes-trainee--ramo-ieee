using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuigiMove : MonoBehaviour
{
    private Rigidbody2D rig;
    [SerializeField] private float speed;
    private Animator anim;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        rig.velocity = new Vector2(xMove, yMove) * speed * Time.fixedDeltaTime;

        if(xMove == 0 && yMove == 0)
        {
            anim.Play("playerIdle");
        }
        else
        {
            anim.Play("playerWalk");
            if (xMove > 0)
                transform.eulerAngles = new Vector3(0, 0, 0);
            else
                transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}


