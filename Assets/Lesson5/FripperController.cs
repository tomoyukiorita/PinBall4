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

	
	}

	public void SetAngle(float angle){
		JointSpring jointSpr = this.myHingleJoynt.spring;
		jointSpr.targetPosition = angle;
		this.myHingleJoynt.spring = jointSpr;
	}
}
