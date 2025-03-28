using Godot;
using System;

public partial class RotateSky : WorldEnvironment
{
	[Export]
	private float rotationSpeed = 0.8F;

	public override void _Process(double delta)
	{
		this.Environment.SkyRotation = new Vector3(this.Environment.SkyRotation.X, this.Environment.SkyRotation.Y + (0.8F*(float)delta), this.Environment.SkyRotation.Z);
	}
}
