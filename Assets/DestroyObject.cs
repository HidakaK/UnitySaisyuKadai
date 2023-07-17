using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject effectPrefab;
    public GameObject effectPrefab2;
    public int objectHP;
    public AudioClip shotSound;
    public int enemyscore;
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
        if (other.gameObject.tag == "Shell")//íeÇ™ìñÇΩÇ¡ÇΩéû
        {
            objectHP -= 1;
            if (objectHP > 0)
            {
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
                Destroy(other.gameObject);//ãÖÇè¡Ç∑
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                
            }
            else
            {
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
                ScoreSumController.scorenum += enemyscore;
                Destroy(this.gameObject);//ìñÇΩÇ¡ÇΩÇ‡ÇÃÇè¡Ç∑
                GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
                
               // CountEnemy.suvenemysum --;
                
            }
            
        }
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            Destroy(this.gameObject);//ìñÇΩÇ¡ÇΩÇ‡ÇÃÇè¡Ç∑
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
        }
    }
}
