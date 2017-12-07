using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    public Transform centralTower;

    NavMeshAgent agent;


	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(centralTower.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
