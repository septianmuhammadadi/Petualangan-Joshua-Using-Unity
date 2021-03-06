﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public float restartTime;
	bool restartNow = false;
	float resetTime;

	public GameObject gameWinScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(restartNow && resetTime <= Time.time){
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	public void restartTheGame(){
		restartNow = true;
		resetTime = Time.time + restartTime;
	}

	public void CompleteLevel(){
		Animator gameOverAnimator = gameWinScreen.GetComponent<Animator>();
		gameOverAnimator.SetTrigger("winGame");
	}
}
