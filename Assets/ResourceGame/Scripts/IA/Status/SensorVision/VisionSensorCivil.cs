using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionSensorCivil : VisionSensor
{
    [Header("Vision Resources")]
    public DataViewBase ResourcesVision = new DataViewBase();

    [Header("Accommodation View")]
    public Health AccommodationView;

    [Header("Resource View")]
    public Health ResourceView;

    private void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {

        ResourcesVision.Owner = MainVision.Owner;
        base.LoadComponent();
    }

    void Update()
    {
        this.UpdateScand();
    }
    private void OnValidate()
    {
        base.CreateMesh();
        ResourcesVision.CreateMesh();
    }
    public override void Scan()            
    {

        EnemyView=null;
        AlliedView = null;
        AccommodationView = null;
        ResourceView = null;    
        MainVision.InSight = false;

        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVision.distance, ScanLayerMask);

        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
             Health health= targetsInViewRadius[i].GetComponent<Health>();

            if( health!=null &&
                IsNotIsThis(health.gameObject) &&
                !health.IsDead &&
                health.IfCanView &&
                MainVision.IsInSight(health.AimOffset)  
                )
            {
                if (health.typeAgent == TypeAgent.Resources) {
                    ResourceView = health;
                }
                else if(health.typeAgent == TypeAgent.Accommodation)
                {
                    AccommodationView = health;
                }
                else    
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


        if (ResourceView != null)
        {
            ResourcesVision.IsInSight(ResourceView.AimOffset);
        }
        else
            ResourcesVision.InSight = false;
    }
    private void OnDrawGizmos()
    {
        ResourcesVision.OnDrawGizmos();
        base.DrawGizmos();
    }
}
