using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    
    public ObjectColorSelection _colorSelection;
    void Start()
    {
        _colorSelection = GetComponent<ObjectColorSelection>();
        _colorSelection.GetColor();
        StartSpawn();
    }
    public void StartSpawn()
    {
        var sphere = Instantiate(_sphere);
        var sphereColor = sphere.GetComponent<Renderer>();
        sphereColor.material.color = _colorSelection.color;
        sphere.transform.position = new Vector3(Random.Range(-40, 40), 1.0f, Random.Range(-40, 40));
    }
}
