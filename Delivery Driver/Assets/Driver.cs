using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _steerSpeed = 0.5f;
    [SerializeField] private float _moveSpeed = 0.01f;
    
    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float moveSpeed = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveSpeed, 0);
    }
}
