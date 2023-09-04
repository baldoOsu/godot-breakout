using Godot;
using System;

public partial class Ball : CharacterBody2D
{
  private Vector2 _startPos;
	private Vector2 _vel = new Vector2(200, -200);
	private const float _multiplier = 1.05f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	this._startPos = this.Position;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var collisionInfo = MoveAndCollide(this._vel * (float)delta);
		if (collisionInfo != null)
		{
			this._vel = _multiplier * this._vel.Bounce(collisionInfo.GetNormal());

			string colliderName;

			try {
				colliderName = collisionInfo.GetCollider().GetMeta("Name").AsString();
			} catch {}

		}
	}
}
