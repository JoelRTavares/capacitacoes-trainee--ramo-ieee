using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBotao : MonoBehaviour
{
    [SerializeField] private GameObject puzzlePanel;
    [SerializeField] private Color normalColor;
    [SerializeField] private Color pressedColor;

    [SerializeField] private Image correct, correct2;
    [SerializeField] private Image incorrect, incorrect2;

    [SerializeField] private Animator door;

    [SerializeField] private Text resultText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changeColor(Image but)
    {
        if (but.color == normalColor)
            but.color = pressedColor;
        else
            but.color = normalColor;
    }

    public void DesactivePuzzlePanel()
    {
        puzzlePanel.SetActive(false);
    }

    public void CheckResult(GameObject but)
    {
        if(correct.color == pressedColor && correct2.color == pressedColor && incorrect.color == normalColor && incorrect2.color == normalColor)
        {
            door.Play("DoorOpen");
            resultText.text = "ACESSO LIBERADO!";
            Destroy(but);
        }
        else
        {
            resultText.text = "SENHA ERRADA!";
            Debug.Log("Errou");
        }
    }
}
