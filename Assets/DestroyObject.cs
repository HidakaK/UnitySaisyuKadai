using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shell")//弾が当たった時
        {
            Destroy(this.gameObject);//当たったものを消す
            Destroy(other.gameObject);//球を消す
        }
    }
}
