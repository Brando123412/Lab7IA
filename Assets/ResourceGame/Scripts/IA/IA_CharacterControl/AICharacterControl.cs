using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class AICharacterControl : MonoBehaviour
{
    protected VisionSensor visionSensor;
    protected Health health;
    public virtual void LoadComponent()
    {

    }
}
