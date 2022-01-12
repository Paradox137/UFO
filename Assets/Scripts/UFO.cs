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
    private float _rotationMultiplier = 0.85f;

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
            _leftLegRb.AddRelativeForce(Vector3.up * _speed * _rotationMultiplier);

            _rightLegRb.AddRelativeForce(Vector3.up * _speed);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            _leftLegRb.AddRelativeForce(Vector3.up * _speed);

            _rightLegRb.AddRelativeForce(Vector3.up * _speed * _rotationMultiplier);
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
            Debug.Log("Enemy");

            _sceneLoader.LoadScene(0);
        }

        if (collision.gameObject.tag == "Friend")
        {
            Debug.Log("Friend");
        }
    }
    private void FixedUpdate()
    {

    }
}
