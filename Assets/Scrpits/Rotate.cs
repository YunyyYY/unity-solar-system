using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Transform Origin;    //各天体公转的圆心
	public float Gspeed;        //公转速度
	public float Zspeed;        //自转速度
	public float Ry, Rz;        //通过y轴、z轴调整公转的偏心率，使其不在同一平面公转

	void Start() {

	}

	void FixedUpdate () {
		Vector3 axis = new Vector3 (0, Ry, Rz);     //公转轴
		this.transform.RotateAround (Origin.position, axis, Gspeed * Time.deltaTime);   //公转
		this.transform.Rotate (Vector3.up * Zspeed * Time.deltaTime);       //自转
	}  
}