using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacterVehicle : AICharacterControl
{
    #region Rate
    protected int index = 0;
    protected float[] arrayRate;
    protected int bufferSize = 10;
    public float randomWaitScandMin = 1;
    public float randomWaitScandMax = 1;


    protected float Framerate = 0;
    #endregion
    public override void LoadComponent()
    {
        base.LoadComponent();
        Framerate = 0;
        index = 0;
        arrayRate = new float[bufferSize];
        for (int i = 0; i < arrayRate.Length; i++)
        {
            arrayRate[i] = (float)UnityEngine.Random.Range(randomWaitScandMin, randomWaitScandMax);
        }
    }

    public virtual void LookToEnemy()
    {

    }
    public virtual void LookToPosition(Vector3 position)
    {

    }
    public virtual void MoveToEnemy()
    {


    }
    public virtual void MoveToPosition(Vector3 position)
    {

    }
    public virtual void MoveToEvadeEnemy()
    {
    }
    public virtual void Wander()
    {

    }
    public virtual void MoveToAllied()
    { 
    }
    public virtual void MoveToResource() { }
}
