using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemVida : MonoBehaviour
{
    [SerializeField] private int Life;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Finish"))
        {
            Life--;
            
            if(Life <= 0)
            {
                anim.SetTrigger("die");
                Destroy(gameObject, 1.083f);
            }
            else
            {
                anim.SetTrigger("damage");
            }
        }
    }
}
