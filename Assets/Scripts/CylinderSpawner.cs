using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.CollabMigration;
using UnityEngine;

public class CylinderSpawner : MonoBehaviour
{
    [SerializeField] private int numberOfCylinders = 6;
    [SerializeField] private GameObject _cylinder;
    [SerializeField] private DisplayingNumberOfCylinders _displaying;

    public ObjectColorSelection _colorSelection;
    void Start()
    {
        _colorSelection = GetComponent<ObjectColorSelection>();
        for (int i = 0; i < numberOfCylinders; i++)
        {
            _colorSelection.GetColor();
            CheckColor();
            StartSpawn();
        }
    }
    public void StartSpawn()
    {
        var cylinder = Instantiate(_cylinder);
        var cylinderColor = cylinder.GetComponent<Renderer>();
        cylinderColor.material.color = _colorSelection.color;
        cylinder.transform.position = new Vector3(Random.Range(-60, 60), 1.0f, Random.Range(-60, 60));
    }
    private void CheckColor()
    {
        if (_colorSelection.color == _colorSelection._colors[0])
        {
            _displaying.red++;
        }
        if (_colorSelection.color == _colorSelection._colors[1])
        {
            _displaying.green++;
        }
        if (_colorSelection.color == _colorSelection._colors[2])
        {
            _displaying.yellow++;
        }
    }
   
}
