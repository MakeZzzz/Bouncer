using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private CubeController _cube;
    [SerializeField] private DisplayingNumberOfClicks _clicks;
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, 1000f,_layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var target = hitInfo.point;
                _cube.StartMove(target);
                Debug.Log(_cube);
                _clicks.click++;
            }
        }
    }
}
