namespace RonSijm.Flowmailer.DataTypes;

public class items_range
{
    public int? Skip { get; set; }
    public int Take { get; set; }

    public override string ToString()
    {
        if (!Skip.HasValue)
        {
            return $"items=:{Take}";
        }

        return $"items={Skip.Value}-{Take}";
    }
}