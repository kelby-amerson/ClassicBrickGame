using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
        {
            transform.Translate(-20 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(20 * Time.deltaTime, 0, 0);
        }

        float h = (float)(30.0 * Time.deltaTime * Input.GetAxis("Mouse X"));
        transform.Translate(h, 0, 0);
	}

    private void OnTriggerEnter(Collider other)
    {
        BallScript.yspeed = -BallScript.yspeed;

        if (other.gameObject.transform.position.x > gameObject.transform.position.x)
        {
            BallScript.xspeed = Mathf.Abs(BallScript.xspeed);
        }
        else
        {
            BallScript.xspeed = -Mathf.Abs(BallScript.xspeed);
        }

        BallScript.collflag = true;
    }
}
