// By Ruoyu Li

using UnityEngine;
using System.Collections;



public class map : MonoBehaviour {

    //static int[] dim = new int[2] { (int)size.x, (int)size.y };

    //static int[] init = new int[2] { (int)initial.x, (int)initial.y };
    public int[] size = { 3, 3 };

    //player position
    public int[] initial = { 0, 0 };
    public int[] monsterPos = { 1, 0 };
    public int[] coinPos = { 1, 1 };

    

    public Transform block;
    public Transform wall;
    public Transform coin;
    public Transform monster;
    NavMeshAgent nav;
    // Use this for initialization
    void Start()
    {

        int i, j;
        int m, n;
        mazeBlock.blockUnit[,] proto = new mazeBlock.blockUnit[size[0], size[1]];
        mazeBlock.blockUnit current = proto[initial[0], initial[1]];
        //GameObject a = ;


        //initializing the map, which by default connects all the neighboring blocks and walls are on the fringe
        for (i = 0; i < size[0]; i++)
        {
            for (j = 0; j < size[1]; j++)
            {
                if (i == 0)
                    proto[i, j].ifForward = false;
                else
                    proto[i, j].ifForward = true;
                if (i == size[0] - 1)
                    proto[i, j].ifBackward = false;
                else
                    proto[i, j].ifBackward = true;
                if (j == 0)
                    proto[i, j].ifLeft = false;
                else
                    proto[i, j].ifLeft = true;
                if (j == size[1] - 1)
                    proto[i, j].ifRight = false;
                else
                    proto[i, j].ifRight = true;

                proto[i, j].isCurrent = false;
                proto[i, j].ifMonster = false;
                proto[i, j].ifCoin = false;
            }
        }
        current.isCurrent = true;


        //prototype map
        proto[0, 1].ifBackward = false;
        proto[1, 1].ifForward = false;
        proto[1, 1].ifRight = false;
        proto[1, 1].ifBackward = false;
        proto[1, 2].ifLeft = false;
        proto[2, 0].ifRight = false;
        proto[2, 1].ifLeft = false;
        proto[2, 1].ifForward = false;

        //monster position
        proto[monsterPos[0], monsterPos[1]].ifMonster = true;
        proto[coinPos[0], coinPos[1]].ifCoin = true;

        for (i = 0; i < size[0]; i++)
        {
            for (j = 0; j < size[1]; j++)
            {
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

                Vector3 pos = new Vector3(GameObject.Find("FPSController").transform.position.x + n * (10 * Mathf.Abs(j - initial[1])), 0,
                    GameObject.Find("FPSController").transform.position.z - m * (10 * Mathf.Abs(i - initial[0])));

                Instantiate(block, pos, Quaternion.identity);
                if (!proto[i, j].ifForward) Instantiate(wall, pos + new Vector3(0, 0, 5), Quaternion.identity);
                if (!proto[i, j].ifBackward) Instantiate(wall, pos + new Vector3(0, 0, -5), Quaternion.identity);
                if (!proto[i, j].ifLeft) Instantiate(wall, pos + new Vector3(-5, 0, 0), Quaternion.Euler(0, 90, 0));
                if (!proto[i, j].ifRight) Instantiate(wall, pos + new Vector3(5, 0, 0), Quaternion.Euler(0, -90, 0));
                if (proto[i, j].ifMonster) Instantiate(monster, pos + new Vector3(0, 1, 0), Quaternion.identity);
                if (proto[i, j].ifCoin) Instantiate(coin, pos + new Vector3(0, 2, 0), Quaternion.identity);
            }
        }
    }
    
	// Update is called once per frame
	void Update () {
	
	}
}
