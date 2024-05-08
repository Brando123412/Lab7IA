using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.UIElements;
[TaskCategory("IA SC/ Node Range / Eye")]
public class ActionNotDistanceColliderFire : ActionRange
{
    public override void OnStart()
    {
        base.OnStart();

    }
    /*
    public override TaskStatus OnUpdate()
    {
        if (_AICharacterVehicle != null)
        {
            if (_AICharacterVehicle.Health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }
        else
            if (_AICharacterAction != null)
        {
            if (_AICharacterAction.Health.IsDead)
            {
                return TaskStatus.Failure;
            }
        }
        return SwitchUnity();
    }
    TaskStatus SwitchUnity()
    {
        switch (UnitSC)
        {

            case UnitSC.Zergling:
                float distance = (trasnform.position - _AICharacterAction.IAEye.ViewEnemy.transform.position).magnitud;
                if (distance > distanceOneLand)
                {
                    return TaskStatus.Failure;
                }
                return TaskStatus.Success;
                break;

            case UnitSC.None:
                break;
            default:
                break;
        }
        return TaskStatus.Failure;
    }          */
}