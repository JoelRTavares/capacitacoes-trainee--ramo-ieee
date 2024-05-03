using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacaDePressao : MonoBehaviour
{
    [SerializeField] private Animator doorAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Crate") || collision.CompareTag("Player"))
        {
            doorAnim.Play("DoorOpen");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Crate") || collision.CompareTag("Player"))
        {
            doorAnim.Play("DoorClose");
        }
    }
}
