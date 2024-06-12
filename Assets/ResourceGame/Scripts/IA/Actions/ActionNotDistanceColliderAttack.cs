using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.UIElements;

public class ActionNotDistanceColliderAttack : ActionRange
{
    public override void OnStart()
    {
        base.OnStart();
    }
    
    public override TaskStatus OnUpdate()
    {
        return TaskStatus.Failure;
    }                /*
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
    }            */
}