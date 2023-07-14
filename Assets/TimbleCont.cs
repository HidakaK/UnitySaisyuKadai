using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimbleCont : MonoBehaviour
{
    private Quaternion DefaultRotation;
    // Start is called before the first frame update
    void Start()
    {
        DefaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = DefaultRotation;
        }
    }
}
