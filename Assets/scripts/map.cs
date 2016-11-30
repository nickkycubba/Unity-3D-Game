// By Ruoyu Li

using UnityEngine;
using System.Collections;



public unsafe class map : MonoBehaviour {

    //static int[] dim = new int[2] { (int)size.x, (int)size.y };

    //static int[] init = new int[2] { (int)initial.x, (int)initial.y };
    public int[] size = { 3, 3 };

    public int[] initial = { 2, 1 };

    public Transform block;
    // Use this for initialization
    void Start () {
        
        int i, j;
        int m, n;
        mazeBlock.blockUnit *[,] proto = new mazeBlock.blockUnit *[(size[0]), (size[1])];
        mazeBlock.blockUnit * current = proto[initial[0], initial[1]];
        //GameObject a = ;
        
        
        //initializing the map, which by default connects all the neighboring blocks
        for (i = 0; i < size[0]; i++)
        {
            for (j = 0; j < size[1]; j++)
            {
                if (i == 0)
                    proto[i, j]->forward = null;
                else
                    proto[i, j]->forward = proto[i - 1, j];
                if (i == size[0] - 1)
                    proto[i, j]->backward = null;
                else
                    proto[i, j]->backward = proto[i + 1, j];
                if (j == 0)
                    proto[i, j]->left = null;
                else
                    proto[i, j]->left = proto[i, j - 1];
                if (j == size[1] - 1)
                    proto[i, j]->right = null;
                else
                    proto[i, j]->right = proto[i, j + 1];

                proto[i, j]->isCurrent = false;
                proto[i, j]->ifMonster = false;
                proto[i, j]->ifCoin = false;

                if (i > initial[0])
                    m = 1;
                else if (i == initial[0])
                    m = 0;
                else
                    m = -1;

                if (j > initial[1])
                    n = 1;
                else if (j == initial[1])
                    n = 0;
                else
                    n = -1;

                Instantiate(block, new Vector3(m * (2.5f + Mathf.Abs(i - initial[0])), n * (2.5f + Mathf.Abs(j - initial[1])), 0), Quaternion.identity);
            }
        }
        current->isCurrent = true;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
