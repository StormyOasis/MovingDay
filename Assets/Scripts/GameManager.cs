using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager gameManager;
	public GameObject boxSpawner;

	// Use this for initialization
	void Start () {
		if (gameManager == null) 
			gameManager = this.gameObject.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			foreach (Transform childTransform in boxSpawner.transform) {
				Destroy (childTransform.gameObject);
			}
		}
	}
}
