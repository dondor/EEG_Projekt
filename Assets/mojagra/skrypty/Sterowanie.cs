using UnityEngine;
using System.Collections;
using Leap;

public class Sterowanie : MonoBehaviour {
	public float maxSpeed =10f;
	public float przyspieszenie=100f;
	public float szybkoscY=10f;
	public WyswietlZdrowie zdrowie;
	public GameObject pociskPrefab;
	Controller controller;
	// Use this for initialization
	void Start () {
		controller = new Controller();
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame();
		this.transform = frame.Translation;

		if (Input.GetKeyDown (KeyCode.W)) {
			
			GameObject nowy = (GameObject)Instantiate (pociskPrefab, new Vector2 (0, 0), Quaternion.identity);
			nowy.rigidbody2D.position = new Vector2 (transform.position.x, transform.position.y+1.5f);
		}

	
	}
		void FixedUpdate()
	{



		if(Input.GetKey (KeyCode.A)&&rigidbody2D.velocity.x>-maxSpeed)
		

				rigidbody2D.velocity=(new Vector2(rigidbody2D.velocity.x-przyspieszenie,szybkoscY));
		
		else
			if(Input.GetKey(KeyCode.D)&&rigidbody2D.velocity.x<maxSpeed)

				rigidbody2D.velocity=(new Vector2(rigidbody2D.velocity.x+przyspieszenie,szybkoscY));

		
		//tarcie
		rigidbody2D.velocity = rigidbody2D.velocity * 0.99f;


	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "zdrowieBonus")
						zdrowie.ZwiekszZdrowie ();
			else
		zdrowie.ZmniejszZdrowie ();

			Destroy(other.gameObject);
	
	}


}
