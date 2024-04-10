using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button button1 = root.Q<Button>("Button1");
        Button button2 = root.Q<Button>("Button2");
        Button button3 = root.Q<Button>("Button3");


        button1.clicked += ButtonClicked;
        button2.clicked += ButtonClicked;
        button2.clicked += ButtonClicked;
    }
       

    private void ButtonClicked()
    {
        Debug.Log("ButtonPressed");
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
