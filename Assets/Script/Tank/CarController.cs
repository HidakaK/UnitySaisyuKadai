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
    public float jumpSpeed;
    private bool isJUmp=false;
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
        //jump
        if (Input.GetKeyDown(KeyCode.J)&&isJUmp==false)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isJUmp = true;
        }
    }
    private void Move()
    {
        MoveInputValue = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * MoveInputValue * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);//èuä‘à⁄ìÆ
    }
    private void Turn()
    {
        TurnInputValue = Input.GetAxis("Horizontal");
        float turn = TurnInputValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation=Quaternion.Euler(0,turn,0);
        rb.MoveRotation(rb.rotation * turnRotation); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        isJUmp = false;
    }
}
