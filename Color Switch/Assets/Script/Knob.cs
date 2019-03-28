using UnityEngine;
using UnityEngine.SceneManagement;

public class Knob : MonoBehaviour {

	public float speed = 10f; 
	public Rigidbody2D rb;
	public string currentColor;
	public SpriteRenderer sr;
	public Color colorCyan;
	public Color colorYellow;
	public Color colorPurple;
	public Color colorPink;

	void Start(){
	
		setRandomColor ();
	}

	void Update (){

		if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")){
			rb.velocity = Vector2.up * speed;
		}
	}	
	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "ColorChanger") {
		
			setRandomColor ();
			Destroy (col.gameObject);
			return;
		}
	
		if (col.tag != currentColor) {
		
			Restart ();
		}
	}

	void setRandomColor(){
	
		int index = Random.Range (0, 4);
		switch (index)
		{
		case 0:
			currentColor = "Cyan";
			sr.color = colorCyan;
			break;
		case 1:
			currentColor = "Yellow";
			sr.color = colorYellow;
			break;
		case 2:
			currentColor = "Purple";
			sr.color = colorPurple;
			break;
		case 3:
			currentColor = "Pink";
			sr.color = colorPink;
			break;
		}
	}
	void Restart(){
	
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}