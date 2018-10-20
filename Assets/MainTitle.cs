using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainTitle : MonoBehaviour {

    public Texture aTexture;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.DrawTexture(
            new Rect(0, 0, Screen.width, Screen.height),
            aTexture);
        if (Input.anyKeyDown)
        {
            Debug.Log("A key or mouse click has been detected");
            SceneManager.LoadScene("BrickScene", LoadSceneMode.Single);
        }
    }
}
