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
    protected Health MyHealth;
    protected TypeAgent _TypeUnity;
    public override void OnStart()
    {
        _AICharacterVehicle = GetComponent<AICharacterVehicle>();
        if (_AICharacterVehicle == null)
        {
            Debug.LogWarning("Not load component");
        }
        _AICharacterAction = GetComponent<AICharacterAction>();
        if (_AICharacterAction == null)
        {
            Debug.LogWarning("Not load component");
        }

        if (_AICharacterVehicle != null)
        {
            _TypeUnity = this._AICharacterVehicle.health.typeAgent;
        }
        else if (_AICharacterAction != null)
        {
            _TypeUnity = this._AICharacterAction.health.typeAgent;
        }             
    }
}
