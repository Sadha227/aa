using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 100f;

    void Start()
    {
        
    }
    void Update() 
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
