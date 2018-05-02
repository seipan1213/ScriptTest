using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public class Boss
    {
        private int hp = 100;
        private int power = 25;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }
    }

    void Start () {
        Boss lastboss = new Boss();
        Boss midboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);

        midboss.Attack();

        midboss.Defence(30);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
