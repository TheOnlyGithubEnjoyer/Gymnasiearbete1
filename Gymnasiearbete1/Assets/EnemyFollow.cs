using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
  public NavMeshAgent enemy;
  public Transform cowboy;

  void Update(){
    enemy.SetDestination(cowboy.position);
  }



}
