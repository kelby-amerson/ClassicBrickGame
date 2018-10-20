using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int y = 0; y < 8; y++)
        {
            for(int x = 0; x < 15; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x * 2 - 14, y - 1, 0);
                cube.transform.localScale = new Vector3(1.9f, 0.9f, 1.1f);
                cube.AddComponent<BrickScript>();
                cube.GetComponent<Collider>().isTrigger = true;
                if (y < 2)
                    cube.GetComponent<Renderer>().material.color = new Color(1, 0.92f, 0.016f, 1);
                else if(y<4)
                    cube.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
                else if(y<6)
                    cube.GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
                else
                    cube.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);

            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
