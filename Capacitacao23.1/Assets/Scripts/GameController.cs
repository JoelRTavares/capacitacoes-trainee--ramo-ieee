using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject puzzlPanel;

    [SerializeField] private Color normalColor;
    [SerializeField] private Color pressedColor;

    [SerializeField] private Image correct, correct2, incorrect, incorrect2;

    [SerializeField] private Animator gateAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseWindow()
    {
        puzzlPanel.SetActive(false);
    }
    public void ChangeColor(Image im)
    {
        if(im.color == normalColor)
        {
            im.color = pressedColor;
        }
        else
        {
            im.color = normalColor;
        }
    }
    public void CheckButtons()
    {
        if(correct.color == pressedColor && correct2.color == pressedColor&& incorrect.color == normalColor&& incorrect2.color == normalColor)
        {
            gateAnim.Play("PortaAbrindo");
            Debug.Log("Abrir portao");
        }
        else
        {
            Debug.Log("Errou senha");
        }
    }
}
