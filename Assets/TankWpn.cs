using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankWpn : MonoBehaviour
{
    public GameObject effectPrefab;
    public GameObject effectPrefab2;
    public int tankHP;
    public int tankHPMax;
    public AudioClip Hitsound;
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
        if (other.gameObject.tag == "EShell")
        {
            tankHP -= 1;
            Destroy(other.gameObject);
            if (tankHP > 0)
            {
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                Destroy(effect, 1.0f);
                AudioSource.PlayClipAtPoint(Hitsound, transform.position);
            }
            else
            {
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);
                Destroy(gameObject);
            }
        }
    }
    public void AddHP(int amount)
    {
        tankHP += amount;
        if (tankHP > tankHPMax)
        {
            tankHP = tankHPMax;
        }

    }
}
