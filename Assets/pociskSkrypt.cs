using UnityEngine;
using System.Collections;

public class pociskSkrypt : MonoBehaviour {
	private GameObject gracz;
	// Use this for initialization
	void Start () {
		gracz = GameObject.FindGameObjectsWithTag ("bohater")[0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate()
	{
		if (this.transform.position.y > gracz.transform.position.y+15f)
			DestroyObject (this);


	}
}
