using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTopScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        BallScript.yspeed = -BallScript.yspeed;
        BallScript.collflag = true;
    }
}
