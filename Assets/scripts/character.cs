using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public float rotationSpeed;
    public float movementSpeed;
    public GameObject laser;
    public float cooldown = 1f;
    private float time = 0f;

    // Update is called once per frame
    void Update()
    {

        if (time > 0f)
        {
            time -= Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(laser, transform.TransformPoint(Vector3.forward * 2), transform.rotation);
            time = cooldown;
        }

        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody>().AddForce(transform.up * movementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(transform.up * -movementSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

    }

}