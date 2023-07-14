using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFloor : MonoBehaviour
{
    private float UpDown;
    // Start is called before the first frame update
    void Start()
    {
        UpDown = 0.02f;
    }

    // Update is called once per frame -24.1 -0.35
    void Update()
    {
        if (this.transform.position.y >= -10f)
        {
            UpDown =-0.02f;
        }
        if (this.transform.position.y <= -35f)
        {
            UpDown = 0.02f;
        }
        this.transform.Translate(0, UpDown, 0);
    }
    
}
