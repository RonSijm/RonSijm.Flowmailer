namespace RonSijm.Flowmailer.DataTypes;

// ReSharper disable once InconsistentNaming
public class date_range
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    public override string ToString()
    {
        return Start.ToString("yyyy-MM-ddTHH:mm:ssZ") + ";" + End.ToString("yyyy-MM-ddTHH:mm:ssZ");
    }
}