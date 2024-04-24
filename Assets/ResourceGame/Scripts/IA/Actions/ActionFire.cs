using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

[TaskCategory("IA SC/Node Attack")]
public class ActionFire : AntionNodeActions
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        if(_AICharacterAction.health.IsDead)
            return TaskStatus.Failure;
        SwitchFirePlay();
        return TaskStatus.Success;
    }

    void SwitchFirePlay()
    {
        switch (_TypeUnity)
        {
            case TypeUnity.Police:
                break;
            case TypeUnity.Thief:
                break;
            default:
                break;
        }
        
    }
}
