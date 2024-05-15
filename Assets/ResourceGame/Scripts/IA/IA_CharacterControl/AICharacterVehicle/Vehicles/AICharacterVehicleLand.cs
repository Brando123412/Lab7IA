using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacterVehicleLand : AICharacterVehicle
{
    protected NavMeshAgent agent;
    public float rangeWander;
    public Vector3 pointWander;
    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    #region move
    public override void MoveToPosition(Vector3 position)
    {
        NavMeshHit hit;
        if (NavMesh.SamplePosition(position,out hit, agent.radius,NavMesh.AllAreas)) 
        agent.SetDestination(position);
    }
    public override void MoveToPositionWander(Vector3 pos) {
        Debug.Log("Move Wander");
    }
    public override void MoveToEnemy()
    {
        //if () return;

    }

    public virtual void Wander()
    {
        //float distance = 8;
    }
    #endregion

    #region Look
    public override void LookPosition(Vector3 posLook) {
        Debug.Log("Look position");
    }
    public virtual void LookToEnemy()
    {
        Debug.Log("Look position");
    }

    #endregion
}
