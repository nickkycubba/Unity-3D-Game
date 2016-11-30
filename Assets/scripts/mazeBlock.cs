// By Ruoyu Li

using UnityEngine;
using System.Collections;

public unsafe class mazeBlock : MonoBehaviour {

    public unsafe struct blockUnit
    {
        public blockUnit* left;
        public blockUnit* right;
        public blockUnit* forward;
        public blockUnit* backward;

        public bool ifMonster;
        public bool ifCoin;
        public bool isCurrent;

    };

    
    

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate () {

    }
}
