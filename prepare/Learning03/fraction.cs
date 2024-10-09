using System;
using System.Diagnostics.Contracts;
public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction () 
    {
    }

    public Fraction (int top)
    {
        this._top = top;
        this._bottom = 1;  
    }

    public Fraction (int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    public int getTop()
    {
        return _top;
    }
    public int getBottom()
    {
        return _bottom;
    }

    public void setTop (int top)
    {
        _top = top;
    }

    public void setBottom (int bottom)
    {
        _bottom = bottom;
    }

    public string getFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double getDecimalValue()
    {
        return(double)_top / (double) _bottom;
    }

}