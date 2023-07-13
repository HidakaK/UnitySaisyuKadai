using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenCoin : MonoBehaviour
{
    double gen = 5;
    public GameObject coinPrefab;
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
        if (other.gameObject.tag == "Player")
        {

            for (double i = 0; i < gen; i++) { }

            float x = Random.Range(-400f, -420f);
            float z = Random.Range(-384f, -400f);
            Vector3 pos = new Vector3(x, 2f, z);
            Instantiate(coinPrefab, pos, Quaternion.identity);
        }
            Destroy(this.gameObject);

        }
    }

