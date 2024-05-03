using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float Speed;
    Rigidbody2D rig;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//entre -1 e 1
        float vertical = Input.GetAxis("Vertical");

        rig.velocity = new Vector2(horizontal, vertical) * Speed;

        if(horizontal == 0 && vertical == 0)
        {
            anim.SetInteger("transition", 0);
        }
        else
        {
            anim.SetInteger("transition", 1);
        }
        if(horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
