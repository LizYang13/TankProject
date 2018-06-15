using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour {

    public GameObject shellExplosionPrefab; //爆炸实例

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

    //当子弹碰撞到其他碰撞体
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (other.tag == "Tank")
        {
            other.SendMessage("TakeDamage");
        }
        
    }
}
