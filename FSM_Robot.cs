using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_Robot : StateMachineBehaviour
{
    public GameObject robot;
    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject player;

    public float speed = 2.0f;
    public float rotSpeed = 1.0f;
    public float accuracy = 3.0f;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        robot = animator.gameObject;
        player = robot.GetComponent<Robot_Controller>().GetPlayer();
        agent = robot.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}
