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
    public virtual void MoveToPositionEvade(Vector3 pos) { }
    //public virtual void MoveToPositionWanderEnemy() { }
    public virtual void MoveToPositionWander(Vector3 pos) { }
    public virtual void MoveToAllied() { }
    public virtual void MoveToEnemy() { }
    #endregion
    #region Look
    public virtual void LookPosition(Vector3 posLook) { }
    
    #endregion
}
