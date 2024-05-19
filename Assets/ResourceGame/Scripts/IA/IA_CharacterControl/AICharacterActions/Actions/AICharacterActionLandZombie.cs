using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AICharacterActionLandZombie : AICharacterActionCombat
{
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public void Attack()
    {
        Debug.Log("ATTACK");
    }
}
