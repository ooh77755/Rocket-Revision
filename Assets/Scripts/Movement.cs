using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotationThrust = 100f;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotate();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessRotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
            rb.freezeRotation = false;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.freezeRotation = true;
            transform.Rotate(-Vector3.forward * rotationThrust * Time.deltaTime);
            rb.freezeRotation = false;
        }
    }
}
