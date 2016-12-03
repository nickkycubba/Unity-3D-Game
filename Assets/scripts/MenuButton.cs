﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

    public Button playB;

	// Use this for initialization
	void Start () {
        playB.onClick.AddListener(() =>
       {
           //Application.LoadLevel("demoLevel"); //This is obsolete now, they now provide an async way to call this for better performance
           SceneManager.LoadSceneAsync("demoLevel");
       });
	}
}