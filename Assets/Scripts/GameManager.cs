using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void showText(string text)
    {
        dialogBox.SetActive(true);
        dialogText.text = text;
    }

    public void hideText()
    {
        dialogBox.SetActive(false);
        dialogText.text = "";

    }
}
