using System.Collections.Generic;
using System.Text.Json.Serialization;
public class FeatureCollection
{
    
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature

{
    [JsonPropertyName("propeties")]

    public Properties Properties {get; set;}
    
}

public class Properties
{
    [JsonPropertyName("mag")]
    public decimal Magnitude{get; set;}

    [JsonPropertyName("place")]

    public  string Place{get; set;}
    
}