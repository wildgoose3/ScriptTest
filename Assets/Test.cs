using UnityEngine;
using System.Collections;

public class Boss
{
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
    int[] array = {10,30,60,80,65}; 
    // Use this for initialization
    void Start()
    {
        for (int i= 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i =4;i>=0;i--)
        {
            Debug.Log(array[i]);
        }
        Boss lastboss = new Boss();
        for (int j = 0; j < 10; j++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
    }
	
	// Update is called once per frame
	void Update ()
    {

	}
}
