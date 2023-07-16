using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour
{
    public GameObject shellPrefab;
    public float shotSpeed;
    public AudioClip shotSound;
    public int shotCount;
    public int shotCountMax;
    private float timeBetweenShot = 0.5f;
    private float timer;
    public Text shellnumLabel;
    // Start is called before the first frame update
    void Start()
    {
        shellnumLabel.text = "c‚è–C’e”" + shotCount;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&&timer>timeBetweenShot)
        {
            if (shotCount < 1)//‹Ê‚ÌãŒÀ
            {
                return;
            }
            shotCount -= 1;
            shellnumLabel.text = "c‚è–C’e”" + shotCount;
            timer = 0f;
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity) as GameObject;
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * shotSpeed);
            Destroy(shell, 4.0f);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
        }
    }
    public void AddShell(int amount)
    {
        shotCount += amount;
        if (shotCount > shotCountMax)
        {
            shotCount = shotCountMax;
        }
        shellnumLabel.text = "–C’e‚Ì”" + shotCount;
    }
}
