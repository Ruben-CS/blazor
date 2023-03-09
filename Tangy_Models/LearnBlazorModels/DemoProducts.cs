namespace Tangy_Models.LearnBlazorModels;

public class DemoProducts
{
    public int                    Id         { get; set; }
    public string                 Name       { get; set; }
    public double                 Price      { get; set; }
    public bool                   IsActive   { get; set; }
    public List<DemoProductProp>? Properties { get; set; }
}