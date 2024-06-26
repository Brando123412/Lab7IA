using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

[TaskCategory("IA SC/Node Resouces Action")]
public class ActionSeekCave : ActionNodeActions
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
        else
        {
            if (_AICharacterVehicle._VisionSensor is VisionSensorCivil)
            {
                VisionSensorCivil visionSensor = (VisionSensorCivil)_AICharacterVehicle._VisionSensor;

                if (visionSensor.ResourcesVision.InSight)
                {
                    ItemCave current = (ItemCave)visionSensor.ResourceView;
                    current.SeekCharacter(visionSensor.health);
                    return TaskStatus.Success;
                }
            }
            return TaskStatus.Failure;
        }
    }
}
