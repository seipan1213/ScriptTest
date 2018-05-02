using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{

    public class B
    {
        private int mp = 53;

        public void Magic()
        {
            if (mp > 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        B bs = new B();
        for (int i = 0; i < 12; i++)
        {
            bs.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
