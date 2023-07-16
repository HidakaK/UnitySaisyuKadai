using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTank : MonoBehaviour
{
    public GameObject[] itemPrefab;//出すアイテムを入れる配列uh
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
            GameObject dropItem = itemPrefab[Random.Range(0, itemPrefab.Length)];
            Vector3 pos = transform.position;
            Destroy(gameObject);
            Instantiate(dropItem, new Vector3(pos.x,pos.y+0.5f,pos.z), Quaternion.identity);



        }
    }
}
