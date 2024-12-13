namespace blazor_soan_slide.Models;
using System;
using System.Collections.Generic;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using Newtonsoft.Json;

public partial class ProductStore
{
    [JsonProperty("sizes")]
    public int[] Sizes { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("alias")]
    public string Alias { get; set; }

    [JsonProperty("price")]
    public double Price { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("size")]
    public string Size { get; set; }

    [JsonProperty("shortDescription")]
    public string ShortDescription { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    [JsonProperty("deleted")]
    public bool Deleted { get; set; }

    [JsonProperty("categories")]
    public string Categories { get; set; }

    [JsonProperty("relatedProducts")]
    public string RelatedProducts { get; set; }

    [JsonProperty("feature")]
    public bool Feature { get; set; }

    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("imgLink")]
    public string ImgLink { get; set; }
}
