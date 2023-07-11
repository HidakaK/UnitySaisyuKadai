using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float CanonRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float rotate = 0f;
        if (Input.GetKey(KeyCode.Q))
        {
            rotate = -1f;
        }else if(Input.GetKey(KeyCode.E)) { rotate = 1f; }
        transform.Rotate(Vector3.up* rotate *CanonRotation * Time.deltaTime);
    }
}
