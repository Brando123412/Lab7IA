using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACharacterHumanVehicle : AICharacterVehicleLand, IIACharacterHumanAction
{
    
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public void InCave(ItemCave _cave)
    {
        agent.isStopped = true;
        transform.position = _cave.IntroCavePosition.position;
    }

    public void OutCave(ItemCave _cave)
    {

        transform.position = _cave.OutCavePosition.position;
        agent.isStopped = false;
    }
}
