using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZombie : Health
{
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
}
