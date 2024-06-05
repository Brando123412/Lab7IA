using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[TaskCategory("IA SC/ Node View")]
public class ActionViewCave : ActionView
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_AICharacterVehicle != null)
        {
            if (_AICharacterVehicle.health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }
        if (_AICharacterVehicle != null)
        {
            if (_AICharacterVehicle._VisionSensor.EnemyView != null)
            {
                return TaskStatus.Success;
            }
        }
        else
        if (_AICharacterAction != null)
        {
            if (_AICharacterAction._VisionSensor.EnemyView != null)
            {
                return TaskStatus.Success;
            }
        }

        return TaskStatus.Failure;
    }
}
