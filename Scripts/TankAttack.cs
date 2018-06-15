using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

    public GameObject shellPrefab;  //获取子弹实例
    public KeyCode fireKey = KeyCode.Space; //发射按键
    private Transform firePosition; //坦克发射的位置组件
    public float shellSpeed = 15; //子弹速度
    public AudioClip shotAudio;

	// Use this for initialization
	void Start () {
        firePosition = transform.Find("FirePosition");
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shotAudio, transform.position);
            GameObject go=  GameObject.Instantiate(shellPrefab, firePosition.position,firePosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;

        }
		
	}
}
