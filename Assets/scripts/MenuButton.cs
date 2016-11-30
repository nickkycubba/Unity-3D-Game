using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {


    public Button playB;

	// Use this for initialization
	void Start () {

        playB.onClick.AddListener(() =>
       {
           Application.LoadLevel("demoLevel");
       });
	
	}
	
	
}
