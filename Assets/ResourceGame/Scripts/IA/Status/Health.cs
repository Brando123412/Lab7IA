using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeUnity {Police,Thief,None}

public class Health : MonoBehaviour
{
    int _Life;
    public bool IsDead{ get=> _Life == 0;}
    public Transform AimOffset;
    public TypeUnity _Unity;
}