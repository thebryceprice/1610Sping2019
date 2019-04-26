using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
   private NavMeshAgent _nav;
   private Transform _player;

   
   //AI MOVEMENT from Unity Tutorial
   private void Start()
   {
      //Bar Enemy
      _nav = GetComponent<NavMeshAgent>();
      //Keep track of the players xyz coordinates
      _player = GameObject.FindGameObjectWithTag("Player").transform;
   }

   private void Update()
   {
      //Enemy will chase player by trying to match Players position
      _nav.SetDestination(_player.position);
   }
}
