using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    public D_MoveState movementData;
    protected bool animationFinished;
    
   
 public MovementState(Entity entity, FiniteStateMachine stateMachine, string animName, D_MoveState movementData) : base(entity, stateMachine, animName)
    {
        this.movementData = movementData;
    }



public virtual void start ()
{
    aliveGO = Transform.Find("Alive"). gameObject;
    rb = aliveGO.GetComponent<Rigidbody2D> ();
    anim = aliveGO.GetComponent <Animator> ();
}
 public override void Enter()
    {
        base.Enter();
        Debug.Log ("You are in the movement state");
        //entity.atsm.MovementState = this;
        //animationFinished = false;
        
    }

    public override void Exit()
    {
        Debug.Log ("You left the movement state");
        base.Exit();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        Move();
    }

    public virtual void FinishMovement()
    {
        animationFinished = true;
    }

   private void Move(){

        Vector3 movement= entity.movement;

   }
 
}
