using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InputFieldHandler : MonoBehaviour
{
    public TMP_InputField textField;

    public void SaveTextAndLoadScene()
    {
        string inputText = textField.text;
        PlayerPrefs.SetString("TextData", inputText);
        SceneManager.LoadScene(1);
    }
}
