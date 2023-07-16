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
        if (other.gameObject.tag == "Shell")//弾が当たった時
        {
            objectHP -= 1;
            if (objectHP > 0)
            {
                Destroy(other.gameObject);//球を消す
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
            }
            else
            {
                ScoreSumController.scorenum += enemyscore;
                Destroy(this.gameObject);//当たったものを消す
                GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
                
                CountEnemy.suvenemysum --;
                
            }

            
            
        }
    }
}
