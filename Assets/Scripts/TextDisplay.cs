using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text textUI;

    private void Start()
    {
        string savedText = PlayerPrefs.GetString("TextData");
        textUI.text = savedText;
    }
}
