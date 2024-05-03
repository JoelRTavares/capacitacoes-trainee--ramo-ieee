using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computador : MonoBehaviour
{
    private bool canShowPuzzle;
    [SerializeField] private GameObject puzzle;
    [SerializeField] private GameObject tutorialTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && canShowPuzzle)
        {
            puzzle.SetActive(true);
            tutorialTxt.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            canShowPuzzle = true;
            tutorialTxt.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canShowPuzzle = false;
            tutorialTxt.SetActive(false);
        }
    }
}
