using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacterVehicleLandGuard : AICharacterVehicleLand
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

    private void OnDrawGizmos()
    {
        if (!IsDrawGizmos) return;

        Gizmos.color = WanderPosition;
        Gizmos.DrawWireSphere(pointWander, 1f);
    }
}
