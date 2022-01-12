using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _leftLegRb;

    [SerializeField]
    private float _speed = 10f;

    [SerializeField]
    private Rigidbody _rightLegRb;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _leftLegRb.AddRelativeForce(Vector3.up * _speed); // 0 1 0
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rightLegRb.AddRelativeForce(Vector3.up * _speed); // 0 1 0
        }
    }

    private void FixedUpdate()
    {

    }
}
