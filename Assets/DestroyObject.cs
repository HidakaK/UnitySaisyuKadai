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
        if (other.gameObject.tag == "Shell")//�e������������
        {
            objectHP -= 1;
            if (objectHP > 0)
            {
                Destroy(other.gameObject);//��������
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
            }
            else
            {
                Destroy(this.gameObject);//�����������̂�����
                GameObject effect = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
                Destroy(this.gameObject);
                CountEnemy.suvenemysum --;
                ScoreSumController.scorenum += enemyscore;
            }
            
            
        }
    }
}
