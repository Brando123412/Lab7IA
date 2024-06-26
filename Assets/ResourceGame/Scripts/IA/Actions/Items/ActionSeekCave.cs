using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

[TaskCategory("IA SC/Node Resouces Action")]
public class ActionSeekCave : ActionWait
{
    public bool Intro = false;
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
                    
                    ItemCave current = ((ItemCave)visionSensor.AccommodationView);
                    if (current != null && !Intro)
                    {
                        
                        //current.SeekCharacter(visionSensor.health);
                        if(_AICharacterAction is AICharacterActionLandCivil)
                        {
                            
                            ((AICharacterActionLandCivil)_AICharacterAction).InCave(current);
                            ((AICharacterVehicleLandCivil)_AICharacterVehicle).InCave(current);
                        }
                        else
                        if (_AICharacterAction is AICharacterActionLandMilitar)
                        {
                            ((AICharacterActionLandMilitar)_AICharacterAction).InCave(current);
                            ((AICharacterVehicleLandMilitar)_AICharacterVehicle).InCave(current);
                        }
                        Intro = true;
                        return TaskStatus.Success;
                    }
                    

                    if(Intro)
                    {
                        Debug.Log("Wait: "+ FrameRate + " waitDuration: " + waitDuration);
                        if (FrameRate> waitDuration)
                        {
                            if (_AICharacterAction is AICharacterActionLandCivil)
                            {

                                ((AICharacterActionLandCivil)_AICharacterAction).OutCave(current);
                                ((AICharacterVehicleLandCivil)_AICharacterVehicle).OutCave(current);
                            }
                            else
                            if (_AICharacterAction is AICharacterActionLandMilitar)
                            {
                                ((AICharacterActionLandMilitar)_AICharacterAction).OutCave(current);
                                ((AICharacterVehicleLandMilitar)_AICharacterVehicle).OutCave(current);
                            }
                            Intro = false;
                            FrameRate = 0;
                            return TaskStatus.Success;
                        }
                        FrameRate += Time.deltaTime;
                        // Otherwise we are still waiting.
                        return TaskStatus.Running;
                    }
                }
            }
            return TaskStatus.Failure;
        }
    }
}
