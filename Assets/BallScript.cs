using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallScript : MonoBehaviour {
    public AudioClip BeepSound;
    AudioSource audioSource;

    public static float launchtimer;
    public static float xspeed;
    public static float yspeed;
    public static bool collflag;
    public static int collCounter;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        launchtimer = 2.0f;
        xspeed = 8.0f;
        yspeed = -8.0f;
        collflag = true;
        collCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 p = transform.position;
        p.z = 0;
        launchtimer -= Time.deltaTime;
        if (launchtimer <= 0.0)
        {
            transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);
            launchtimer = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(BeepSound, 1);
        collCounter++;
        if (collCounter == 8)
        {
            Debug.Log("increase speed");
            xspeed += 2;
            yspeed += 2;
            collCounter = 0;
        }
    }
}
