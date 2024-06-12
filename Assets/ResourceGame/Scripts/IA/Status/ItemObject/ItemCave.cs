using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCave : Item
{
    public List<Health> npc_Civil = new List<Health>();
    private void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }

    public void Add(Health npc)
    {
        if (npc.IsDead) return;

        ((HealthCivil) npc).Hide();
        npc_Civil.Add(npc);
    }
    public void Remove(Health npc)
    {
        ((HealthCivil)npc).Show();
        npc_Civil.Remove(npc);
    }
}
