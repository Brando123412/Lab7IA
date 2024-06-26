using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.UIElements;
[TaskCategory("IA SC/ Node Range / Eye")]
public class ActionDistanceColliderFire : ActionRange
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        return TaskStatus.Failure;
    }
}