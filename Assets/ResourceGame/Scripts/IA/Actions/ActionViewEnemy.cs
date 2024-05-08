using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/ Node View")]
public class ActionViewEnemy : ActionView
{

    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        /*if (_AICharacterVehicle != null)
        {
            if (_AICharacterVehicle.AIEye.ViewEnemy != null)
            {
                return TaskStatus.Success;
            }
        }
        else
        if (_AICharacterAction != null)
        {
            if (_AICharacterAction.AIEye.ViewEnemy != null)
            {
                return TaskStatus.Success;
            }
        }
              */
        return TaskStatus.Failure;
    }
}