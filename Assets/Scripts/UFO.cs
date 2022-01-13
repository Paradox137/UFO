using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _leftLegRb;

    [SerializeField]
    private float _speed = 4f;

    [SerializeField]
    private Rigidbody _rightLegRb;

    [SerializeField]
    private float _rotationMultiplier = 0.7f;

    [SerializeField]
    private SceneLoader _sceneLoader;
    private void Start()
    {
        _sceneLoader = FindObjectOfType<SceneLoader>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _leftLegRb.AddRelativeForce(Vector3.up * _speed * _rotationMultiplier * 0.6f);

            _rightLegRb.AddRelativeForce(Vector3.up * _speed * 0.6f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            _leftLegRb.AddRelativeForce(Vector3.up * _speed * 0.6f);

            _rightLegRb.AddRelativeForce(Vector3.up * _speed * _rotationMultiplier * 0.6f);
        }

        else if(Input.GetKey(KeyCode.Space))
        {
            _leftLegRb.AddRelativeForce(Vector3.up * _speed);
            _rightLegRb.AddRelativeForce(Vector3.up * _speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            _sceneLoader.RestartScene();
        }

        if (collision.gameObject.tag == "Friend")
        {
            _sceneLoader.NextScene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            _sceneLoader.RestartScene();
        }
    }
    private void FixedUpdate()
    {

    }
}
