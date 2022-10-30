using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    private void Start()
    {
        var control = _cube.GetComponent<CubeController>();
        _cube = control.gameObject;
    }
}
