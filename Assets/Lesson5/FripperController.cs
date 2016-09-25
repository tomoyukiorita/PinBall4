using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour {
	private HingeJoint myHingleJoynt;

	private float defaultAngle = 20f;

	private float flickAngle = -20f;

	// Use this for initialization
	void Start () {
		this.myHingleJoynt = GetComponent<HingeJoint> ();

		SetAngle (this.defaultAngle);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.flickAngle);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}

		if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
			SetAngle (this.defaultAngle);
		}

		if (Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began&& Input.touches[0].position.x > Screen.width / 2 && tag == "LeftFripperTag"){
				
				SetAngle (this.flickAngle);
			}

			else if (touch.phase == TouchPhase.Ended)
			{
				SetAngle (this.defaultAngle);
			}
		}

		if (Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began && Input.touches[0].position.x > Screen.width / 2 && tag == "RightFripperTag")
			{
				SetAngle (this.flickAngle);
			}

			else if (touch.phase == TouchPhase.Ended)
			{
				SetAngle (this.defaultAngle);
			}
		}

		if (Input.touchCount>0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began && Input.touches[0].position.x > Screen.width / 2 && tag == "RightFripperTag" && Input.touches[0].position.x > Screen.width / 2 && tag == "RightFripperTag")
			{
				SetAngle (this.flickAngle);
			}

			else if (touch.phase == TouchPhase.Ended)
			{
				SetAngle (this.defaultAngle);
			}
		}

	
	}

	public void SetAngle(float angle){
		JointSpring jointSpr = this.myHingleJoynt.spring;
		jointSpr.targetPosition = angle;
		this.myHingleJoynt.spring = jointSpr;
	}
}
