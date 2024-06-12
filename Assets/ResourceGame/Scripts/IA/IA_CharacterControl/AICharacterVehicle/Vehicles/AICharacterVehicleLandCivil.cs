using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacterVehicleLandCivil : AICharacterVehicleLandSmart
{
    public UnityEngine.Color WanderPosition;
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();

    }
    public void MoveToCave()
    {
        if (((VisionSensorCivil)_VisionSensor).AccommodationView != null)
            MoveToPosition(((VisionSensorCivil)_VisionSensor).AccommodationView.transform.position);
    
    }
    private void OnDrawGizmos()
    {
        if (!IsDrawGizmos) return;

        Gizmos.color = WanderPosition;
        Gizmos.DrawWireSphere(pointWander, 1f);
    }
}
