using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	private Vector2 _vel = new Vector2(80, 80);
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var collisionInfo = MoveAndCollide(_vel * (float)delta);
		if (collisionInfo != null)
		{
			_vel = new Vector2(-_vel.Y, _vel.X);
			this.Position.Bounce(_vel.Normalized());
		}
	}
}
