using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TaskCategory("IA SC/Node Move")]
public class ActionEvade : ActionNodeVehicle
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if (_AICharacterVehicle.health.IsDead)
        {
            return TaskStatus.Failure;
        }

        SwitchCharacter();
        return TaskStatus.Success;
    }
    void SwitchCharacter()
    {

        switch (_TypeUnity)
        {
            case TypeAgent.Soldier:
                break;
            case TypeAgent.Zombie:
                break;
            case TypeAgent.Civil:
                ((AICharacterVehicleLandCivil)_AICharacterVehicle).MoveToEvadeEnemy();
                break;
            case TypeAgent.Guard:
                break;
            case TypeAgent.Resources:
                break;
            case TypeAgent.Accommodation:
                break;
            default:
                break;
        }

    }
}
