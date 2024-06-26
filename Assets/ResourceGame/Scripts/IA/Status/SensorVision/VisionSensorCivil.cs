using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionSensorCivil : VisionSensor
{
    [Header("Vision Resources")]
    public DataViewBase ResourcesVision = new DataViewBase();

    [Header("Accommodation View")]
    public Item AccommodationView;

    [Header("Resource View")]
    public Item ResourceView;

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
        ResourceView = null;
        AccommodationView = null;
        ResourcesVision.InSight = false;
        float min_dist = 100000000f;
        float min_dist_item = 100000000f;
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, MainVision.distance, ScanLayerMask);
          
        for (int i = 0; i < targetsInViewRadius.Length; i++) 
        {
            Health health = targetsInViewRadius[i].GetComponent<Health>();

            if (health != null &&
                IsNotIsThis(health.gameObject) &&
                !health.IsDead &&
                //health.IfCanView &&
                MainVision.IsInSight(health.AimOffset)
                )
            {
                ExtractViewEnemy(ref min_dist, health);
            }
            Item ScanItem = targetsInViewRadius[i].GetComponent<Item>();

            if (ScanItem != null && MainVision.IsInSight(ScanItem.transform))
            {
                ExtractViewItem(ref min_dist_item, ScanItem);
            }
        }
    }
    public void ExtractViewItem(ref float min_dist, Item ScanItem)
    {
        float dist = (transform.position - ScanItem.transform.position).magnitude;
        if (min_dist > dist)
        {
            switch (ScanItem.type)
            {
                case TypeItem.Cave:
                    AccommodationView = ScanItem;
                    break;
                case TypeItem.Resource1:
                    ResourceView = ScanItem;
                    break;
                case TypeItem.Resource2:
                    ResourceView = ScanItem;
                    break;
                case TypeItem.Resource3:
                    ResourceView = ScanItem;
                    break;
                default:
                    Debug.Log("Recurso no encontrado");
                    break;
            }
            min_dist = dist;
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
            ResourcesVision.IsInSight(ResourceView.AimOffset);
        else if (AccommodationView != null)
            ResourcesVision.IsInSight(AccommodationView.AimOffset);
        else
            ResourcesVision.InSight = false;
    }
    private void OnDrawGizmos()
    {
        ResourcesVision.OnDrawGizmos();
        base.DrawGizmos();
    }
}
