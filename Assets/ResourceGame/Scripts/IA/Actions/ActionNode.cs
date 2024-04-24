using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;

[TaskCategory ("IA SC/Node Base")]

public class ActionNode : Action
{
    protected AICharacterVehicle _AICharacterVehicle;
    protected AICharacterAction _AICharacterAction;
    protected TypeUniy _TypeUniy;
    public override void OnStart()
    {
        _AICharacterVehicle = GetComponent<AICharacterVehicle>();
        if (_AICharacterVehicle == null)
        {
            Debug.LogWarning("Not load component");
        }
        _AICharacterAction = GetComponent<_AICharacterAction>();
        if (_AICharacterAction == null)
        {
            Debug.LogWarning("Not load component");
        }

        if (_AICharacterVehicle != null)
        {
            _TypeUniy = this._AICharacterVehicle.Health._Unity;
        }
        else if (_AICharacterAction != null)
        {
            _TypeUniy = this._AICharacterAction.Health._Unity;
        }
        base.OnStart();
    }
}
