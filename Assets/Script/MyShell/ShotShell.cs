using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour
{
    public GameObject shellPrefab;
    public float shotSpeed;
    public AudioClip shotSound;
    public int shotCount;
    private float timeBetweenShot = 0.5f;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&&timer>timeBetweenShot)
        {
            timer = 0f;
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity) as GameObject;
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * shotSpeed);
            Destroy(shell, 4.0f);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
        }
    }
}
