using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayingNumberOfClicks : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _click;

    public int click;
    
    void Update()
    {
        _click.text = click.ToString();
    }
}
