﻿using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
	public static bool isPaused = false;
	public GameObject MenuUI;
	void Start(){
		Resume();
	}

	void Update(){

		if (Input.GetKeyDown(KeyCode.Escape)){
			if (isPaused){
				Resume();
			}else{
				Pause();
			}
		}


	}
	public void Resume(){
		MenuUI.SetActive(false);
		Time.timeScale = 1f;
		isPaused = false;
	}

	public void Pause(){
		MenuUI.SetActive(true);
		Time.timeScale = 0f;
		isPaused=true;
	}

	public void Quit(){
		Application.Quit();
	}

	public void mainMenu(){
		SceneManager.LoadScene("mainmenu");
	}
}
