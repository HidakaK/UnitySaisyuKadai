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

            ScoreSumController.scorenum += 1000;
        }
            Destroy(this.gameObject);

        }
    }

