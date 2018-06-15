 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 30;
    public float number = 1; //增加玩家编号，区分不同控制
    private Rigidbody rigidbody;

    public AudioClip idleAudio; //停止的声音 
    public AudioClip drivingAudio; //运动的声音
    private AudioSource audio; 

	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
	}


    private void FixedUpdate()
    {
        //得到上下按键
        float v =Input.GetAxis("VerticalPlayer"+number); //一个-1到1的值，1是向前，-1向后
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("HorizontalPlayer"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if(Mathf.Abs(h)>0.1 || Mathf.Abs(v) > 0.1)
        {
            audio.clip = drivingAudio;
            if(audio.isPlaying==false)
            audio.Play();
        }
        else
        {
            audio.clip = idleAudio;
            if (audio.isPlaying == false)
                audio.Play();
        }


    }
}
