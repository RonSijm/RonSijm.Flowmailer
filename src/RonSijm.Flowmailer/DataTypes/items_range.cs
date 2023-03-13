using System.Net.Http.Headers;

namespace RonSijm.Flowmailer.DataTypes;

public class items_range : RangeHeaderValue
{
    public items_range()
    {
        Unit = "Items";
    }
}