using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Patrol : FSM_Robot
{
  public GameObject[] wp;
  public int currentwp;
  private void Awake()
  {
    wp = GameObject.FindGameObjectsWithTag("Waypoint");
  }

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    base.OnStateEnter(animator, stateInfo, layerIndex);
    currentwp = 0;
  }

  public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
    base.OnStateUpdate(animator, stateInfo, layerIndex);
    if (Vector3.Distance(wp[currentwp].transform.position, robot.transform.position) < accuracy)
    {
      currentwp = currentwp + 1;
      if (currentwp >= wp.Length)
        currentwp = 0;
    }

    agent.SetDestination(wp[currentwp].transform.position);
  }
}
