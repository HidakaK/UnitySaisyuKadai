using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    Rigidbody rb;
    float MoveInputValue;
    float TurnInputValue;
    public float moveSpeed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
    }
    private void Move()
    {
        MoveInputValue = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * MoveInputValue * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }
    private void Turn()
    {
        TurnInputValue = Input.GetAxis("Horizontal");
        float turn = TurnInputValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation=Quaternion.Euler(0,turn,0);
        rb.MoveRotation(rb.rotation * turnRotation); 
    }
}
