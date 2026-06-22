using Godot;

public partial class EffectText : Label
{
    [Export]
    public Sprite2D sprite;

    public int currentFrame = 0;

    public override void _Ready()
    {
        currentFrame = sprite.Frame;
    }

    public override void _Process(double delta)
    {
        currentFrame = sprite.Frame;

        switch (currentFrame)
        {
            case 1:
                Text = "Half Speed!";
                break;
            case 2:
                Text = "Do Double Damage!";
                break;
            case 3:
                Text = "Inverted Controls!";
                break;
            case 4:
                Text = "Ice Physics!";
                break;
            case 5:
                Text = "Halve Your HP!";
                break;
            case 6:
                Text = "Halve Enemy HP!";
                break;
            case 7:
                Text = "Walk through walls!";
                break;
            case 8:
                Text = "Some shit";
                break;
        }
    }
}
