using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WyswietlZdrowie : MonoBehaviour {
public	int zdrowie;
public	int zdrowieMax;
	public GameObject prefab;
	List<GameObject> serca = new List<GameObject>();
	// Use this for initialization
	void Start () {
		DodajSerca ();

	}
	void DodajSerca(){
		for (int i =0; i<zdrowie; i++) {
			GameObject obiekt=(GameObject)Instantiate (prefab, new Vector2 (transform.position.x+((float)i*0.5f), transform.position.y), Quaternion.identity);
			obiekt.transform.parent=transform;
			serca.Add(obiekt);
		}	
	
	
	}
	public void ZmniejszZdrowie(){

		zdrowie--;
		foreach (GameObject obiekt in serca) {
			DestroyObject(obiekt);		
		}
		serca.Clear ();
		DodajSerca ();
		}
	public void ZwiekszZdrowie(){
		zdrowie++;
		foreach (GameObject obiekt in serca) {
			DestroyObject(obiekt);		
		}
		serca.Clear ();
		DodajSerca ();
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
