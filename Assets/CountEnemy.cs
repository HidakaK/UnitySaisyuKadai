using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CountEnemy : MonoBehaviour
{
    public static int suvenemysum;
    public int enemysum;
    public GameObject warplast;
    
    // Start is called before the first frame update
    void Start()
    {
        suvenemysum = enemysum;
    }

    // Update is called once per frame
    void Update()
    {/*

        if (suvenemysum == enemysum)
        {
            SceneManager.LoadScene("BeforeLast");
        }*/
        if (suvenemysum < 4)
        {
            Vector3 pos = transform.position;
            
            Instantiate(warplast, new Vector3(pos.x, pos.y + 0.5f, pos.z), Quaternion.identity);
            return;
        }
    }
}
