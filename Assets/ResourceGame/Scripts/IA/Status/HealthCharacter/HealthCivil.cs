using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCivil : Health
{
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public void Hide()
    {
        IfCanView = false;
    }
    public void Show()
    {
        IfCanView = true;
    }
    public override void DoDamage(int dmg, Health hit)
    {
        
        base.DoDamage(dmg, hit);
        Debug.Log($"Civel Recibi danno de : {hit.gameObject.name}" + " damage: "+dmg);
    }
}
