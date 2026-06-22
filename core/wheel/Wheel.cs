using Godot;

public partial class Wheel : Node2D
{
    [ExportCategory("Wheel Vars")]
    [Export]
    public AnimationPlayer animationPlayer;

    [Export]
    public Timer stopTimer;

    [Export]
    public Sprite2D sprite;

    private readonly RandomNumberGenerator _random = new();

    public override void _Ready()
    {
        stopTimer.WaitTime = _random.RandfRange(0.8f, 1.2f);
        GD.Print($"Spin duration: {stopTimer.WaitTime} seconds");

        stopTimer.Timeout += OnTimerTimeout;

        StartSpinning();
    }

    public void StartSpinning()
    {
        animationPlayer.Play("spinning");

        stopTimer.Start();
    }

    private void OnTimerTimeout()
    {
        animationPlayer.Pause();

        GD.Print("Wheel stopped spinning!");
    }
}
