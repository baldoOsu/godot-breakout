using Godot;
using System;

public partial class Bat : CharacterBody2D
{
	private float MOVE_SPEED = 800.0f;
	private float pos_Y;

	public override void _Ready()
	{
		pos_Y = this.Position.Y;
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 input_direction = new Vector2(
			Input.GetActionStrength("left") - Input.GetActionStrength("right"),
			0
		);

		MoveAndCollide(input_direction * MOVE_SPEED * (float)delta);
		this.Position = new Vector2(this.Position.X, pos_Y);

	}
}
