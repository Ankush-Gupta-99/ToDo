using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text Item;
    public GameObject Container;
    public InputField inputField;
    void Start()
    {
        
    }
    public void Run()
    {
        Text Element= Instantiate(Item,Container.transform);
        Element.text=inputField.text;
        inputField.text = "";
    }
}
