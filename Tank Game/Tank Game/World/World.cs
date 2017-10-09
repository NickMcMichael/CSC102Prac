using System;

public class World
{
    public int player1Score { get; private set; }
    public int player2Score { get; private set; }
    private double gravity { public get; set; }
    private double wind { public get; set; }

	public World()
	{
	}
}
