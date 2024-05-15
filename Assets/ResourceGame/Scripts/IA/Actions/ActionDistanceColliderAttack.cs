using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.UIElements;
[TaskCategory("IA SC/ Node Range / Eye")]
public class ActionDistanceColliderAttack : ActionRange
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
            if (_AICharacterVehicle._VisionSensor is VisionSensorAttack)
            {
                if (((VisionSensorAttack)_AICharacterVehicle._VisionSensor).AttackVision.InSight)
                    return TaskStatus.Success;
            }
        }
        return TaskStatus.Failure;
    }    /*
    TaskStatus SwitchUnity()
    {
        switch (UnitSC)
        {

            case UnitSC.Zergling:
                float distance = (trasnform.position - _AICharacterAction.IAEye.ViewEnemy.transform.position).magnitud;
                if (distance < distanceOneLand)
                {
                    return TaskStatus.Success;
                }
                return TaskStatus.Failure;
                break;

            case UnitSC.None:
                break;
            default:
                break;
        }
        return TaskStatus.Failure;
    }         */
}