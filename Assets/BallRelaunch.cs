using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallRelaunch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0, -7, -1);
        BallScript.xspeed = 8.0f;
        BallScript.yspeed = -8.0f;
        BallScript.launchtimer = 1.0f;
        Scoring.lives--;
        if(Scoring.lives == 0)
        {
            SceneManager.LoadScene("BrickScene", LoadSceneMode.Single);
        }
    }
}
