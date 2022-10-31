using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _force = 20f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private GameObject _plane;
    [SerializeField] private Canvas _canvas;

    private ObjectColorSelection _colorSelection;
    private DisplayingNumberOfCylinders _displaying;
    private Renderer _cubeColor;
    private SphereSpawner _sphere;
    private CylinderSpawner _cylinder;
    private void Start()
    {
       
        _cubeColor = GetComponent<Renderer>();
        _sphere = _plane.GetComponent<SphereSpawner>();
        _cylinder = _plane.GetComponent<CylinderSpawner>();
        _displaying = _canvas.GetComponent<DisplayingNumberOfCylinders>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cylinder"))
        {
            var color = collision.gameObject.GetComponent<Renderer>();
            if (color.material.color == _cubeColor.material.color)
            {
                CheckColorAndRefreshCylinderCounter();
                Destroy(collision.gameObject);
            }
        }
        
        if (collision.gameObject.CompareTag("Sphere"))
        {
            var color = collision.gameObject.GetComponent<Renderer>();
            _cubeColor.material.color = color.material.color;
            Destroy(collision.gameObject);
            _sphere._colorSelection.GetColor();
            _sphere.StartSpawn();
        }

        if (collision.gameObject.CompareTag("Border"))
        {
            _rigidbody.transform.position = new Vector3(0, 3, 0);
        }
    }
    public void StartMove(Vector3 target)
    {
        var result = (target - transform.position).normalized;
        _rigidbody.AddForce(new Vector3(result.x, 0, result.z) * _force);
    }
    private void CheckColorAndRefreshCylinderCounter()
    {
        if (_cubeColor.material.color == _cylinder._colorSelection._colors[0])
        {
            _displaying.red--;
        }
        if (_cubeColor.material.color == _cylinder._colorSelection._colors[1])
        {
            _displaying.green--;
        }
        if (_cubeColor.material.color == _cylinder._colorSelection._colors[2])
        {
            _displaying.yellow--;
        }
    }
    
}
