using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TankWpn : MonoBehaviour
{
    public GameObject effectPrefab;
    public GameObject effectPrefab2;
    public int tankHP;
    public int tankHPMax;
    public AudioClip Hitsound;
    public Text tankHPLabel;
    
    // Start is called before the first frame update
    void Start()
    {
        tankHPLabel.text = "Žc‚èHP" + tankHP;
        
    }

    // Update is called once per frame
    void Update()
    {
        tankHPLabel.text = "Žc‚è‘Ì—Í" + tankHP;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EShell")
        {
            tankHPLabel.text = "Žc‚è‘Ì—Í" + tankHP;
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
                SceneManager.LoadScene("Gameover");
            }
        }
        if (other.gameObject.tag == "Bom")
        {
            
            tankHP -= 5;
            Destroy(other.gameObject);
            if (tankHP > 0)
            {
                GameObject effect3 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect3, 1.0f);
            }
            else
            {
                GameObject effect3 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect3, 1.0f);
                Destroy(gameObject);
                SceneManager.LoadScene("Gameover");

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
