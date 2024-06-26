using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacterActionLandMilitar : IACharacterHumanAction
{
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public virtual void Collect()
    {

    }
}
