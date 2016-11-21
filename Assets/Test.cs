using UnityEngine;
using System.Collections;

public class Boss
{
    // Magic関数
    public int mp = 53;
    public void Magic()
    {
        if(mp>=5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りない");
        }
    }
}
public class Test : MonoBehaviour
{
    // 配列arrayの宣言
    int[] array = {10,30,60,80,65}; 
    
    // Use this for initialization
    void Start()
    {
        //　要素値の表示
        for (int i= 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //　要素値の逆順表示
        for(int i =4;i>=0;i--)
        {
            Debug.Log(array[i]);
        }

        // Magic関数を10回使用
        Boss lastboss = new Boss();
        for (int j = 0; j < 10; j++)
        {
            lastboss.Magic();
        }
        // Magic関数を10回使った後さらに使用
        lastboss.Magic();
    }
	
	// Update is called once per frame
	void Update ()
    {

	}
}
