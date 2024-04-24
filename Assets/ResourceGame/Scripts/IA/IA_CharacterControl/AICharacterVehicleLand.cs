using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacterVehicleLand : AICharacterVehicle
{
    protected NavMeshAgent agent;
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    #region move
    public override void MoveToPosition(Vector3 position)
    {
        agent.SetDestination(position);
    }
    #endregion
}
