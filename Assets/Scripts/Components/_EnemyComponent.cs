﻿using UnityEngine;
using System.Collections;

public class _EnemyComponent : CharacterComponent {
    /*
	public Zombie enemy;

	private AI enemyAI;

	public AI EnemyAI {
		set { enemyAI = value; }
	}


	protected override void Start () {
		base.Start ();

		enemy = actor as Zombie;

		SetState (CharacterAnimationType.RUN);

		enemyAI.StartAI ( this );
	}

	protected override void Update () {
		base.Update ();

		enemyAI.UpdateAI (this);



	}

	public void Kill(){
		enemy.isAlive = false;
	}

	protected override void FixedUpdate () {
		base.FixedUpdate();


		if (currentCharacterState.animationType == CharacterAnimationType.IDLE ||
			currentCharacterState.animationType == CharacterAnimationType.DEAD) {
			
			dynamicVelocity = new Vector2 (0f, 0f);

		} else if (currentCharacterState.animationType == CharacterAnimationType.RUN) {
			
			dynamicVelocity = new Vector2 (-1f, 0f);

		}

		rb.velocity = new Vector2 (world.BASE_SPEED.x, rb.velocity.y) + dynamicVelocity;
	}

	protected override void OnCollisionEnter2D(Collision2D collision){
		base.OnCollisionEnter2D(collision);
	}

	protected override void OnCollisionExit2D(Collision2D collision){
		base.OnCollisionEnter2D(collision);
	}

	protected override void OnCollisionStay2D(Collision2D collision){
		base.OnCollisionEnter2D(collision);
	}
    */
}
