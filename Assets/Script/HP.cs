using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip getSound;
    private TankWpn TankWpn;
    private int reward = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1f, 0, 0);
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TankWpn = GameObject.Find("Tank").GetComponent<TankWpn>();
            TankWpn.AddHP(reward);
            Destroy(gameObject);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.7f);
            AudioSource.PlayClipAtPoint(getSound, transform.position);


        }
    }
}
