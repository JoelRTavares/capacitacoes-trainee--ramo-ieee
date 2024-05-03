using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int life;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            life--;
            if(life == 0)
            {
                anim.SetTrigger("die");
                Destroy(gameObject, 0.813f);
            }
            else
            {
                anim.SetTrigger("damage");
            }
        }
    }
    
}
