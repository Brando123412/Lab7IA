using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeAgent { Soldier, Zombie, Civil,Guard, Resources, Accommodation}
public class Health : MonoBehaviour
{
    public int health=0;
    public int healthMax= 100;
  

    public TypeAgent typeAgent;
    public TypeAgent[] typeAgentAllies;

    public Transform AimOffset;

    public bool IfCanView = true;

    public bool IsDead { get => health <= 0; }
    public virtual void LoadComponent()
    {
        health = healthMax;
    }

    
}
