using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
	private float visiblePosZ = -6.5f;
	private GameObject gameoverText;
	private GameObject scoreText;

	public int Score = 0;

	// Use this for initialization
	void Start () {
		gameoverText = GameObject.Find ("GameOverText");

		scoreText = GameObject.Find ("Score");

		Score = 0;


	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < visiblePosZ) {
			gameoverText.GetComponent<Text>().text = "Game Over";
		}
	
	}

	void OnCollisionEnter(Collision c){
		string yourTag  = c.gameObject.tag;

		if (yourTag == "SmallStarTag") {
			Score += 10;
		} else if (yourTag == "LargeStarTag") {
			Score += 20;
		} else if (yourTag == "SmallCloudTag") {
			Score += 30;
		} else if (yourTag == "LargeCloudTag") {
			Score += 40;
		}

		scoreText.GetComponent<Text> ().text = "Score:"+Score;


	}
}
