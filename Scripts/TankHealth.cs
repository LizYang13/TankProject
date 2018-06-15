using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public  int hp = 100;
    public GameObject tankExplosion;
    public AudioClip tankExplosionAudio;  //爆炸音效
    public Slider hpSlider; //血量进度条
    private int hpTotal;

	// Use this for initialization
	void Start () {
        hpTotal = hp;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage()
    {
        if (hp <= 0) return;
        hp -= Random.Range(10, 20);
        hpSlider.value = (float)hp / hpTotal;

        if (hp <= 0) //受到伤害后，血量为0控制死亡效果
        {
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
