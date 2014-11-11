using UnityEngine;
using System.Collections;

public class AsteroidaSkrypt : MonoBehaviour {
	private GameObject gracz;
	// Use this for initialization
	void Start () {
		gracz = GameObject.FindGameObjectsWithTag ("bohater")[0];
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if (this.transform.position.y < gracz.transform.position.y-10f)
						DestroyObject (this);
	}
}
