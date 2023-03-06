namespace RonSijm.Flowmailer.Models;

public class FlowStepSchedule
{
    [JsonProperty("maxMessagesPerHour", NullValueHandling = NullValueHandling.Ignore)]
    public int MaxMessagesPerHour { get; set; }
    [JsonProperty("offsetType", NullValueHandling = NullValueHandling.Ignore)]
    public string OffsetType { get; set; }
    [JsonProperty("offsetValue", NullValueHandling = NullValueHandling.Ignore)]
    public int OffsetValue { get; set; }
    [JsonProperty("scheduledTimeTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string ScheduledTimeTemplate { get; set; }
    [JsonProperty("timeRangeDay0", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay0 { get; set; }
    [JsonProperty("timeRangeDay1", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay1 { get; set; }
    [JsonProperty("timeRangeDay2", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay2 { get; set; }
    [JsonProperty("timeRangeDay3", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay3 { get; set; }
    [JsonProperty("timeRangeDay4", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay4 { get; set; }
    [JsonProperty("timeRangeDay5", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay5 { get; set; }
    [JsonProperty("timeRangeDay6", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeRangeDay6 { get; set; }
    [JsonProperty("timeZone", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeZone { get; set; }
}