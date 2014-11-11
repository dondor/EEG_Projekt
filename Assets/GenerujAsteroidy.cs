using UnityEngine;
using System.Collections;

public class GenerujAsteroidy : MonoBehaviour {
	public GameObject prefab;
	public int okresGeneracji;
	public int wspolczynnikIlosci;
	public float wspolczynnikSzybkosci;
	public	float szerokoscGeneratora;
	int licznik=0;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter (Collision col)
	{
		}
	void FixedUpdate()
	{
				licznik++;
				if (licznik > okresGeneracji)
		{
			int ile=(int)(Random.value*wspolczynnikIlosci);
			for(int i =0;i<ile;i++)
						
			{
				GameObject nowy = (GameObject)Instantiate (prefab, new Vector2 (0, 5), Quaternion.identity);
				float liczba2= (Random.value-0.5f)*szerokoscGeneratora;
				nowy.rigidbody2D.position = new Vector2 (transform.position.x+liczba2, transform.position.y);
				float liczba = Random.value;
				nowy.rigidbody2D.velocity = new Vector2 (wspolczynnikSzybkosci*(liczba-0.5f), -1-Random.value*2);		
				nowy.rigidbody2D.angularVelocity=Random.value*10;
			}
			licznik = 0;
				}



		}
}
