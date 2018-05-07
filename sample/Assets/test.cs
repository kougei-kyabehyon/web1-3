using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player {


    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}



public class test : MonoBehaviour {

    // Use this for initialization

    //Add関数
        int Add(int a,int b)
    {
        int c = a + b;
        return c;
    }

    //Callname関数
    void CallName(string name)
    {
        Debug.Log("Hello"+name);
    }

    //sayhello関数
    void SayHello()
    {
        Debug.Log("Say,Hello");
    }
	void Start () {
       
        int answer;
        int i;

       
        //ここから０５０７のコード
        //配列
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

       
        for( i=0;i<5;i++)
        {
            Debug.Log(array[i]);
        }

        //配列簡単初期化

        int[] points = { 83, 99, 52, 93, 15 };

        for (i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }

        SayHello();

        CallName("Tom");


        answer = 0;
        answer = Add(2, 3);
        Debug.Log(answer);

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerpos = new Vector2(3.0f, 4.0f);
        playerpos.x += 8.0f;
        playerpos.y += 5.0f;
        Debug.Log(playerpos);

        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f,5.0f);
        Vector2 dir = endPos = startPos;

        float len = dir.magnitude;
        Debug.Log(len);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
