using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using TMPro;
using System;

public class UnityInputService : MonoBehaviour, IInputService
{
    [SerializeField]
    private TMP_InputField InputField;

    public event EventHandler<string> InputReceived;

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string inputString = InputField.text;

            if (string.IsNullOrEmpty(inputString) == false)
            {
                InputReceived?.Invoke(this, inputString);
            }

            InputField.text = string.Empty;
        }
    }

    public void ProcessInput()
    {
        
    }
}
