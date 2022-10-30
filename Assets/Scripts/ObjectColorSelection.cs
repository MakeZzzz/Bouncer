using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.CollabMigration;
using UnityEngine;

public class ObjectColorSelection : MonoBehaviour
{
    public Color[] _colors = { Color.red, Color.green, Color.yellow };
    public Color color;
    public void GetColor()
    {
        var colorNumber = Random.Range(0, _colors.Length);
        switch (colorNumber)
        {
            case (0):
                color = _colors[0];
                break;
            
            case(1):
                color = _colors[1];
                break;
            
            case(2):
                color = _colors[2];
                break;
        }
    }
}
