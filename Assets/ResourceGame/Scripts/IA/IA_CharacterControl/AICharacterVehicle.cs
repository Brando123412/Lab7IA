using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacterVehicle : AICharacterControl
{
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    #region move
    public virtual void MoveToPosition(Vector3 position) { }
    public virtual void MoveToPositionEvade() { }
    public virtual void MoveToPositionWanderEnemy() { }
    public virtual void MoveToPositionWander() { }
    public virtual void MoveToAllied() { }
    public virtual void MoveToEnemy() { }
    #endregion
}
