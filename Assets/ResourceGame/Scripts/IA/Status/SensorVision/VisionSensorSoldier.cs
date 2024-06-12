using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class VisionSensorSoldier : VisionSensor
{
    [Header("Vision Attack")]
    public DataViewBase AttackVision = new DataViewBase();
    [Header("Vision Fire")]
    public DataViewBase FireVision = new DataViewBase();
    // Start is called before the first frame update


    private void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        FireVision.Owner = GetComponent<Health>();
        AttackVision.Owner = FireVision.Owner;

        base.LoadComponent();
    }

    // Update is called once per frame
    void Update()
    {
        this.UpdateScand();
    }
    private void OnValidate()
    {
        base.CreateMesh();
        AttackVision.CreateMesh();
        FireVision.CreateMesh();
    }
    public override void UpdateScand()
    {
        if (Framerate > arrayRate[index])
        {
            index++;
            index = index % arrayRate.Length;
            this.Scan();
            Framerate = 0;
        }
        Framerate += Time.deltaTime;


        if (EnemyView != null)
        {
            AttackVision.IsInSight(EnemyView.AimOffset);
            FireVision.IsInSight(EnemyView.AimOffset);
        }
        else
        {
            AttackVision.InSight = false;
            FireVision.InSight = false;
        }

    }
    public override void Scan()
    {

        EnemyView = null;
        AlliedView = null;

        MainVision.InSight = false;


        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVision.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Health health = targetsInViewRadius[i].GetComponent<Health>();

            if (health != null &&
                IsNotIsThis(health.gameObject) &&
                !health.IsDead &&
                health.IfCanView &&
                MainVision.IsInSight(health.AimOffset)
                )
            {
                
                 if (!IsAllies(health))
                 {
                     EnemyView = health;
                 }
                 else
                 {
                    AlliedView = health;
                 }
            }
        }
    }
    private void OnDrawGizmos()
    {
        AttackVision.OnDrawGizmos();
        FireVision.OnDrawGizmos();
        base.DrawGizmos();
    }
}
