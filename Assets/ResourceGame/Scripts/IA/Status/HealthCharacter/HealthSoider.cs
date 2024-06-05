using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSoider : Health
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
