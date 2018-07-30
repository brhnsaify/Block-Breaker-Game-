using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	//public bool autoPlay = false;
	private Ball ball;
	public static string action;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
	if(action == "yes"){
		AutoPlay();
	}else{
		PlayOnMouse();
	}
	/*
	if(!autoPlay){
		PlayOnMouse();
	}else{
		AutoPlay();
		}*/
	}

	public void AutoPlay(){
	Vector3 paddlepos = new Vector3(0.5f, this.transform.position.y, 0f);
	Vector3 ballpos = ball.transform.position;
	paddlepos.x=Mathf.Clamp(ballpos.x, 0.5f, 15.5f);

	this.transform.position=paddlepos;
	}

	void PlayOnMouse(){

	Vector3 paddlepos = new Vector3(0.5f, this.transform.position.y, 0f);

	float mousePosInBLocks = Input.mousePosition.x/ Screen.width *16;

	paddlepos.x=Mathf.Clamp(mousePosInBLocks, 0.5f, 15.5f);

	this.transform.position=paddlepos;
		
	}

	public void AutoPlayB(string action1){
		action = action1;
	}

}
