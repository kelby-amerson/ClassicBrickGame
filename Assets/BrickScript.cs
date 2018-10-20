using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(BallScript.collflag == true)
        {
            BallScript.yspeed = -BallScript.yspeed;
            BallScript.collflag = false;
            Destroy(gameObject);
            Scoring.score += 10;
        }
        
    }
}
