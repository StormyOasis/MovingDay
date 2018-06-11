using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCreator : MonoBehaviour {

	public GameObject[] boxPrefabs;
	public float spawnMinTime = 0.15f;
	public float spawnMaxTime = 4.75f;

	public float xMin = 0f;
	public float xMax = 0f;
	public float yMin = 0f;
	public float yMax = 0f;
	public float zMin = 0f;
	public float zMax = 0f;

	private float nextSpawnTime = 0f;

	// Update is called once per frame
	void Update () {
		if (Time.time >= nextSpawnTime) {
			Spawn ();

			nextSpawnTime += Random.Range (spawnMinTime, spawnMaxTime);
		}
	}

	public void Spawn() {
		Vector3 position;

		position.x = Random.Range (xMin, xMax);
		position.y = Random.Range (yMin, yMax);
		position.z = Random.Range (zMin, zMax);

		Quaternion rot = transform.rotation;
		rot.x = Random.Range (0, 360);
		rot.y = Random.Range (0, 360);
		rot.z = Random.Range (0, 360);

		GameObject obj = Instantiate(boxPrefabs[Random.Range (0, 3)], position, rot) as GameObject;

		obj.transform.parent = gameObject.transform;
	}
}
