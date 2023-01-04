using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Robot_Controller : MonoBehaviour
{
 public GameObject bullet;
 public GameObject player;
 public GameObject gun;
 public float hp;
 private Animator anim;

 public GameObject GetPlayer()
 {
     return player;
 }
 
 private void Start()
 {
  anim = GetComponent<Animator>();
 }

 private void Update()
 {
   anim.SetFloat("distance",Vector3.Distance(transform.position,player.transform.position));
   anim.SetFloat("hp", hp);

   if (Input.GetKeyDown(KeyCode.Q))
   {
       hp = hp - 30f;
   }

   if (hp < 40)
   {
       hp = hp + 20f;
   }
 }
 public void ShootMe()
 {
     GameObject shooting = Instantiate(bullet, gun.transform.position, gun.transform.rotation);
     shooting.GetComponent<Rigidbody>().AddForce(gun.transform.right * 800f);
 }

 public void StartShooting()
 {
     InvokeRepeating("ShootMe", 0f, 1f);
 }

 public void StopShooting()
 {
     CancelInvoke("ShootMe");
 }
 
}
