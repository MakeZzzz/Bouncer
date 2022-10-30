using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayingNumberOfCylinders : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _green;
    [SerializeField]
    private TextMeshProUGUI _yellow;
    [SerializeField]
    private TextMeshProUGUI _red;

    public float green = 0;
    public float yellow = 0;
    public float red = 0;
    void Update()
    {
        _green.text = green.ToString();
        _yellow.text = yellow.ToString();
        _red.text = red.ToString();
    }
    
}
