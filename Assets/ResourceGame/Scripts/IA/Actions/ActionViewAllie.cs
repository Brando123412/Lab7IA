using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/ Node View")]
public class ActionViewAllie : ActionView
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        /*if (_AICharacterVehicle.AIEye.ViewAllie != null)
        {
            return TaskStatus.Success;
        }                         */
        return TaskStatus.Failure;  
    }


}