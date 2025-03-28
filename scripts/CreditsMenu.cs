using Godot;
using System;

public partial class CreditsMenu : Label
{
	public override void _Ready()
	{
		this.Text += "\n\nCreated with love in Godot, license for the Godot engine is as follows:\n" + Engine.GetLicenseText();
	}
}
