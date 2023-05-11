using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{
   public Transform objetivo;
   private NavMeshAgent _agente;

   private void Start()
   {
      _agente = GetComponent<NavMeshAgent>();
      
   }

   private void Update()
   {
      _agente.destination = objetivo.position;
   }
}
