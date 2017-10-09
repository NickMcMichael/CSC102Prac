using System;

public class Tank
{
    private int barrelPos { public get; set; }
    private int tankPosx {public get; set;} 
    private int tankPosy { public get; set; }

    public void moveRight()
    {
        tankPosx += 1;
    }
    public void moveLeft()
    {
        tankPosx -= 1;
    }
    public void barrelUp()
    {
        barrelPos += 1;
    }
    public void barrelDown()
    {
        barrelPos -= 1;
    }
	public Tank(int x, int y)
	{
        tankPosx = x;
        tankPosy = y;
        barrelPos = 90;
	}
}
