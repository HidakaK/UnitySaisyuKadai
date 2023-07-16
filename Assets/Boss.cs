using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject effect;
    public GameObject effect2;
    public GameObject goal;
    public AudioClip shotSound;
    public int BossHP;
    public Vector3 Bossbody;
    public Vector3 Bossbody2;
    public Vector3 Bossbody3;
    public Vector3 Bossbody4;
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
            BossHP -= 1;


            if (BossHP ==15)
            {
                this.gameObject.transform.localScale = Bossbody;
                Destroy(other.gameObject);//ãÖÇè¡Ç∑
                GameObject effect1 = Instantiate(effect, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
            }
            else if (BossHP==10)
            {
                this.gameObject.transform.localScale = Bossbody2;
                Destroy(other.gameObject);//ãÖÇè¡Ç∑
                GameObject effect1 = Instantiate(effect, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
            }
            else if (BossHP==5)
            {
                this.gameObject.transform.localScale = Bossbody3;
                Destroy(other.gameObject);//ãÖÇè¡Ç∑
                GameObject effect1 = Instantiate(effect, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
            }
            else if (BossHP ==1)
            {
                this.gameObject.transform.localScale = Bossbody4;
                Destroy(other.gameObject);//ãÖÇè¡Ç∑
                GameObject effect1 = Instantiate(effect, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
            }
   
            else if(BossHP==0)
            {
               
                GameObject effect = Instantiate(effect2, transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
                Destroy(this.gameObject);//ìñÇΩÇ¡ÇΩÇ‡ÇÃÇè¡Ç∑
                ScoreSumController.scorenum += 10000;
            }



        }
    }
}
