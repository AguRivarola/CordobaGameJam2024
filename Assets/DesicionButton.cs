using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DesicionButton : MonoBehaviour
{

    public Button EvilButton;
    public GameController Controller;
    public bool updateEvil;

    // Start is called before the first frame update
    void Start()
    {
        //EvilButton.onClick.AddListener(() => { this.Click(); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickEvil()
    {
        print($"{name} . {Controller == null}");
        Controller.nuevaVictima = true;

        print("Click");
    }
}
